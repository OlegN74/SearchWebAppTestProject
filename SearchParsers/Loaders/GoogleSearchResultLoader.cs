using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Implementation.Loaders
{
    public class GoogleSearchResultLoader: BaseSearchResultLoader
    {
        public override void Configure()
        {
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
