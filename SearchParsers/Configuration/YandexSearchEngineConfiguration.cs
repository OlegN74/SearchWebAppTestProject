using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Configuration
{
    public class YandexSearchEngineConfiguration: ISearchEngineConfiguration
    {
        public string KeyApi { get; set; }

        public YandexSearchEngineConfiguration()
        {
        }

        public YandexSearchEngineConfiguration(string keyApi)
        {
            KeyApi = keyApi;
        }
    }
}
