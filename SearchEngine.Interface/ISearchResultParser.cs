using System.Collections.Generic;

namespace SearchEngine.Contract
{
    public interface ISearchResultParser
    {
        bool TryParse(string content, out IEnumerable<SearchResult> result);
    }
}
