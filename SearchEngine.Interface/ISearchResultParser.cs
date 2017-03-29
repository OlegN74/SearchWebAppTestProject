using System.Collections.Generic;

namespace SearchEngine.Contract
{
    public interface ISearchResultParser
    {
        bool TryParse(string inputData, out IEnumerable<SearchResult> result);
    }
}
