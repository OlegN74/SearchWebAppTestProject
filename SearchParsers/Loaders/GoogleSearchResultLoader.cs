using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Loaders
{
    public class GoogleSearchResultLoader: BaseSearchResultLoader
    {
        public override void Configure(string searchString, ISearchEngineConfiguration config)
        {
            string url =
                @"https://www.googleapis.com/customsearch/v1/?num=2&q=monkey&key=AIzaSyDjQiWzROFIr0bwpi36UP7ofp5I1uNuTr4";
            Logger.Debug("We are in GoogleSearchResultLoader.Configure");
        }

        public override string LoadData()
        {
            string result = String.Empty;
            Logger.Debug("We are in GoogleSearchResultLoader.Configure");

            return result;
        }

    }
}
