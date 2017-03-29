using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Configuration
{
    public class BingSearchEngineConfiguration: ISearchEngineConfiguration
    {
        public string KeyApi { get; set; }

        public BingSearchEngineConfiguration()
        {
        }

        public BingSearchEngineConfiguration(string keyApi)
        {
            KeyApi = keyApi;
        }
    }
}
