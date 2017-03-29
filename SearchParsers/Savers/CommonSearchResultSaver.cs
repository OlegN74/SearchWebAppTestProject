using System;
using System.Collections.Generic;
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

            return result;
        }
    }
}
