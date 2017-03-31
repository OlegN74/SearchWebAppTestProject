using System;
using System.Collections.Generic;
using System.Linq;
using log4net.Repository.Hierarchy;
using SearchEngine.Contract;

namespace SearchEngine.Implementation
{
    public class SearchEngine : ISearchEngine
    {
        private readonly ISearchResultLoader _loader;
        private readonly ISearchResultParser _parser;
        private readonly ISearchResultSaver _saver;
        private readonly ISearchEngineConfiguration _config;
        public string SearchEngineName { get; private set; }

        public SearchEngine()
        {
        }

        public SearchEngine(string searchEngineName, ISearchEngineConfiguration configuration, ISearchResultLoader loader, ISearchResultParser parser, ISearchResultSaver saver)
        {
            SearchEngineName = searchEngineName;
            _config = configuration;
            _loader = loader;
            _parser = parser;
            _saver = saver;
        }

        public string LoadData()
        {
            return _loader.LoadData();
        }

        public bool TryParse(string inputData, out IEnumerable<SearchResult> resultsList)
        {
            return _parser.TryParse(inputData, out resultsList);
        }

        public bool SaveData(IEnumerable<SearchResult> data)
        {
            return _saver.SaveData(data);
        }

        public void Configure(string searchString, ISearchEngineConfiguration config)
        {
            _loader.Configure(searchString, config);
        }

        public IEnumerable<SearchResult> DoWork(string searchString)
        {
            IEnumerable<SearchResult> result;
            try
            {
                Configure(searchString, _config);
                string data = LoadData();
                if (TryParse(data, out result) && result != null)
                {
                    foreach (var item in result.ToList())
                    {
                        item.SearchEngineName = SearchEngineName;
                        item.SearchWords = searchString;
                    }

                    //_saver.SaveData(result);

                }
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }
    }
}
