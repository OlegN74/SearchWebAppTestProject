using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using log4net;
using Microsoft.Practices.Unity;
using SearchEngine.Contract;

namespace SearchWebApp.Controllers
{
    public class HomeController : Controller
    {
        ILog _log = log4net.LogManager.GetLogger(typeof(HomeController));

        private List<SearchEngine.Implementation.SearchEngine> _searchEngines;

        [InjectionConstructor]
        public HomeController(SearchEngine.Implementation.SearchEngine[] searchEngines)
        {
            _searchEngines = searchEngines.ToList();
        }

        public HomeController()
        {
        }

        private List<SearchResult> GetSearchResultData(string searchStringFromUI)
        {
            var cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;

            var result = new List<SearchResult>();

            Task<IEnumerable<SearchResult>>[] tasks = new Task<IEnumerable<SearchResult>>[_searchEngines.Count];
            int i = 0;
            foreach (var engine in _searchEngines)
            {
                tasks[i] = Task.Factory.StartNew(() => engine.DoWork(HttpUtility.UrlEncode(searchStringFromUI)),
                token)
                ;
                ++i;
            }

            try
            {
                int index = Task.WaitAny(tasks);
                result = tasks[index].Result.ToList();
                cancelTokenSource.Cancel();
            }
            catch (OperationCanceledException ex)
            {
                _log.Info("Operation aborted.");
            }
            finally
            {
                cancelTokenSource.Dispose();
            }

            return result;
        }

        public ActionResult Index()
        {
            string searchStringFromUI = "test search string";

            IEnumerable<SearchResult> resultData = new List<SearchResult>();

            var result = GetSearchResultData(searchStringFromUI);
            

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

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}