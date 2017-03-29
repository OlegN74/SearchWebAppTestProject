using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using log4net;
using Microsoft.Practices.Unity;
using SearchEngine.Contract;
using SearchWebApp.DAL;
using SearchWebApp.Extentions;
using SearchWebApp.Models;

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

       private async Task<List<SearchResult>> GetSearchResultData(string searchStringFromUI)
       {
            var result = new List<SearchResult>();

            var tasks = new List<Task<IEnumerable<SearchResult>>>(_searchEngines.Count);
            foreach (var engine in _searchEngines)
            {
                Task<IEnumerable<SearchResult>> task = new Task<IEnumerable<SearchResult>>(() => engine.DoWork(HttpUtility.UrlEncode(searchStringFromUI)));
                tasks.Add(task);
                task.Start();
            }

            while (tasks.Count > 0)
            {
                var t = await Task.WhenAny(tasks);
                tasks.Remove(t);
                try
                {
                    IEnumerable<SearchResult> resultTask = t.Result;
                    result.AddRange(resultTask.ToList());
                    if (result.Count >= (ConfigurationManager.AppSettings["NeedSearchElements"] == null
                                ? 10
                                : int.Parse(ConfigurationManager.AppSettings["NeedSearchElements"])))
                    {
                        tasks.Clear();
                    }
                }
                catch (OperationCanceledException)
                {

                }
                catch (Exception exc)
                {
                    //Handle(exc); 

                }
            }

            return result;
        }

        public ActionResult Index()
        {
            string searchStringFromUI = "test search string";

            using (var ctx = new SearchEngineContext())
            {
                SearchResultViewModel stud = new SearchResultViewModel { SearchEngineName = "Google", Subject="Test subject", SearchWords = searchStringFromUI };

                ctx.SearchResults.Add(stud);
                ctx.SaveChanges();
            }



            //IEnumerable<SearchResult> resultData = new List<SearchResult>();

            //var result = GetSearchResultData(searchStringFromUI);
            

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