using System.Collections.Generic;

namespace SearchEngine.Contract
{
    public interface ISearchResultSaver
    {
        bool SaveData(IEnumerable<SearchResult> data);

    }
}
