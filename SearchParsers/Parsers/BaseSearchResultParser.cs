using System.Collections.Generic;
using log4net;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Parsers
{
    public abstract class BaseSearchResultParser: ISearchResultParser
    {
        protected readonly ILog Logger;

        protected BaseSearchResultParser()
        {
            if (Logger == null)
            {
                Logger = log4net.LogManager.GetLogger(this.GetType());
            }
        }

        protected BaseSearchResultParser(ILog logger)
        {
            Logger = logger;
        }

        public abstract bool TryParse(string inputData, out IEnumerable<SearchResult> result);
    }
}
