using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using log4net;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Savers
{
    public class CommonSearchResultSaver : ISearchResultSaver
    {
        protected readonly ILog Logger;

        public CommonSearchResultSaver()
        {
            if (Logger == null)
            {
                Logger = log4net.LogManager.GetLogger(this.GetType());
            }
        }

        public void Configure()
        {
            Logger.Debug("We are in CommonSearchResultSaver.Configure");
        }

        public bool SaveData(IEnumerable<SearchResult> data)
        {
            bool result = true;

            Logger.Debug("We are in CommonSearchResultSaver.SaveData");
            using (var dbContext = new SearchEngineContext())
            {
                dbContext.SearchResults.AddRange(data);
                int code = dbContext.SaveChanges();
            }
            return result;
        }
    }
}
