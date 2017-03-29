using System.Collections.Generic;

namespace SearchEngine.Contract
{
    public interface ISearchEngine : ISearchResultLoader, ISearchResultParser, ISearchResultSaver
    {
        void Configure();
        bool DoWork();
    }
}
