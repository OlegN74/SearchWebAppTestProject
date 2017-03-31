using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using log4net;
using Microsoft.Practices.Unity;
using SearchEngine.Contract;
using SearchEngine.Implementation.Savers;

namespace SearchWebApp.Controllers
{
    public class HomeController : Controller
    {
        ILog _log = LogManager.GetLogger(typeof(HomeController));

        private List<SearchEngine.Implementation.SearchEngine> _searchEngines;
        private CommonSearchResultSaver _saver;
        private readonly ConcurrentQueue<SearchResult> _queueResults = new ConcurrentQueue<SearchResult>();

        private int NeedTakeItem
        {
            get
            {
                int needTake;
                string needTakeStr = ConfigurationManager.AppSettings["NeedSearchElements"];
                if (string.IsNullOrWhiteSpace(needTakeStr) || !int.TryParse(needTakeStr, out needTake))
                {
                    needTake = 10;
                }

                return needTake;
            }
        }

        [InjectionConstructor]
        public HomeController(SearchEngine.Implementation.SearchEngine[] searchEngines, CommonSearchResultSaver saver)
        {
            _searchEngines = searchEngines.ToList();
            _saver = saver;
        }

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            string searchStringFromUI = "elephant";

            Task<SearchResult[]> result = GetSearchResultData(searchStringFromUI);
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private async Task<SearchResult[]> GetSearchResultData(string searchStringFromUI)
        {
            var cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;

            List<Task<IEnumerable<SearchResult>>> tasks = new List<Task<IEnumerable<SearchResult>>>(_searchEngines.Count);
            foreach (var engine in _searchEngines)
            {
                tasks.Add(Task.Factory.StartNew(() => engine.DoWork(HttpUtility.UrlEncode(searchStringFromUI)), token));
            }

            while (tasks.Count > 0)
            {
                var t = await Task.WhenAny(tasks);
                tasks.Remove(t);
                try
                {
                    var resultTask = (await t).ToList();
                    foreach (var searchResult in resultTask)
                    {
                        _queueResults.Enqueue(searchResult);
                    }

                    if (_queueResults.Count >= NeedTakeItem)
                    {
                        cancelTokenSource.Cancel();
                        while (tasks.Count > 0)
                        {
                            tasks.Remove(tasks.Last());
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    _log.Info("Operation(s) aborted.");
                }
                catch (Exception exc)
                {
                    _log.Info(exc);
                }
                finally
                {
                    cancelTokenSource.Dispose();
                }
            }

            var result = new SearchResult[NeedTakeItem];
            _queueResults.CopyTo(result, 0);
            _log.DebugFormat(CultureInfo.InvariantCulture, "Found {0} items.", result.Length);

            _saver.SaveData(result.ToList());
            return result;
        }

    }
}