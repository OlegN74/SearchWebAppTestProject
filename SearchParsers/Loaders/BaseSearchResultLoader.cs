using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Loaders
{
    public abstract class BaseSearchResultLoader : ISearchResultLoader
    {
        protected readonly ILog Logger;

        protected BaseSearchResultLoader()
        {
            if (Logger == null)
            {
                Logger = log4net.LogManager.GetLogger(this.GetType());
            }
        }

        protected BaseSearchResultLoader(ILog logger)
        {
            Logger = logger;
        }

        public virtual void Configure()
        {
            Logger.Debug("We are in BaseSearchResultLoader.Configure");
        }

        public abstract string LoadData();
    }
}
