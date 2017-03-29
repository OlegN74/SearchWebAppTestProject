using System.Collections.Generic;
using System.Data.Entity;

namespace SearchEngine.Contract
{
    public interface ISearchResultSaver
    {
        bool SaveData(IEnumerable<SearchResult> data);

    }
}
