using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Loaders
{
    public class BingSearchResultLoader: BaseSearchResultLoader
    {
        private string _url;
        public override void Configure(string searchString, ISearchEngineConfiguration config)
        {
            string urlTemplate = @"https://api.cognitive.microsoft.com/bing/v5.0/search?q={0}&key={1}&count={2}";
            _url = String.Format(CultureInfo.InvariantCulture, urlTemplate, searchString, config.KeyApi, config.MaxResultCount);

            Logger.Debug("We are in BingSearchResultLoader.Configure");
            Logger.DebugFormat(CultureInfo.InvariantCulture, "URL: {0}", _url);
        }

        public override string LoadData()
        {
            string result = String.Empty;
            Logger.Debug("We are in BingSearchResultLoader.Configure");

            return result;
        }
    }
}
