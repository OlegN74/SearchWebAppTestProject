using System;
using System.Collections.Generic;
using System.Globalization;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Parsers
{
    public class YandexSearchResultParser: BaseSearchResultParser
    {
        public override bool TryParse(string inputData, out IEnumerable<SearchResult> resultsList)
        {
            bool result = true;
            Logger.Debug("We are in YandexSearchResultParser.TryParse");

            resultsList = new List<SearchResult>();

            return result;
        }
    }
}
