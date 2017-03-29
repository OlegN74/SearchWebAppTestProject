using System.Collections.Generic;

namespace SearchEngine.Contract
{
    public interface ISearchEngine : ISearchResultLoader, ISearchResultParser, ISearchResultSaver
    {
        bool DoWork(string searchString);
    }
}
