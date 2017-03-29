using System.Collections.Generic;

namespace SearchEngine.Contract
{
    public interface ISearchEngine : ISearchResultLoader, ISearchResultParser, ISearchResultSaver
    {
        IEnumerable<SearchResult> DoWork(string searchString);
    }
}
