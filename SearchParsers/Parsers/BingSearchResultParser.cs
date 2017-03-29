using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Parsers
{
    public class BingSearchResultParser: BaseSearchResultParser
    {
        public override bool TryParse(string inputData, out IEnumerable<SearchResult> resultsList)
        {
            bool result = true;
            Logger.Debug("We are in BingSearchResultParser.TryParse");

            resultsList = new List<SearchResult>();

            return result;
        }
    }
}
