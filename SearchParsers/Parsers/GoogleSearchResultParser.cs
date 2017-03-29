using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Parsers
{
    public class GoogleSearchResultParser: BaseSearchResultParser
    {
        public override bool TryParse(string inputData, out IEnumerable<SearchResult> resultsList)
        {
            bool result = true;
            Logger.Debug("We are in GoogleSearchResultParser.TryParse");

            resultsList = new List<SearchResult>();

            return result;
        }
    }
}
