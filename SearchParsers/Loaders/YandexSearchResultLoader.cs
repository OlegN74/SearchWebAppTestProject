using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Implementation.Loaders
{
    public class YandexSearchResultLoader: BaseSearchResultLoader
    {
        public override void Configure()
        {
            Logger.Debug("We are in YandexSearchResultLoader.Configure");
        }

        public override string LoadData()
        {
            string result = String.Empty;
            Logger.Debug("We are in YandexSearchResultLoader.Configure");

            return result;
        }
    }
}
