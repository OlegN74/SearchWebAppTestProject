using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Microsoft.Practices.Unity;
using SearchEngine.Contract;

namespace SearchWebApp.Controllers
{
    public class HomeController : Controller
    {
        private static log4net.ILog Log { get; set; }

        ILog _log = log4net.LogManager.GetLogger(typeof(HomeController));

        private List<SearchEngine.Implementation.SearchEngine> _searchEngines;

        [InjectionConstructor]
        public HomeController(SearchEngine.Implementation.SearchEngine[] searchEngines)
        {
            _searchEngines = searchEngines.ToList();
        }

        public ActionResult Index()
        {
            foreach (var engine in _searchEngines)
            {
                engine.DoWork();
            }
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