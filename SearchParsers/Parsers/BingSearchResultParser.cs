using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Parsers
{
    public class BingSearchResultParser: BaseSearchResultParser
    {
        public override bool TryParse(string inputData, out IEnumerable<SearchResult> resultsList)
        {
            bool result = !String.IsNullOrWhiteSpace(inputData);
            Logger.Debug("We are in BingSearchResultParser.TryParse");

            var resultsList1 = new List<SearchResult>();
            if (result)
            {
                dynamic dynObj = JsonConvert.DeserializeObject(inputData);

                if (dynObj != null)
                {
                    foreach (dynamic item in dynObj.webPages.value)
                    {
                        var resultItem = new SearchResult();
                        resultItem.Published = item.dateLastCrawled.Value;
                        resultItem.RawDara = item.ToString();
                        resultItem.Subject = item.name.Value;
                        resultItem.Text = item.snippet.Value;
                        resultItem.Url = item.url.Value;
                        resultsList1.Add(resultItem);
                    }
                }
            }

            resultsList = resultsList1;

            return result;
        }
    }
}
