using System;
using System.Collections.Generic;
using SearchEngine.Contract;

namespace SearchEngine.Implementation
{
    public class SearchEngine : ISearchEngine
    {
        private readonly ISearchResultLoader _loader;
        private readonly ISearchResultParser _parser;
        private readonly ISearchResultSaver _saver;
        private ISearchEngineConfiguration _config;
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

        public bool DoWork(string searchString)
        {
            bool state = false;
            IEnumerable<SearchResult> result = new List<SearchResult>();
            try
            {
                Configure(searchString, _config);
                string data = LoadData();
                state = TryParse(data, out result);
                if (state)
                {
                    state = SaveData(result);
                }
            }
            catch (Exception e)
            {
                state = false;
                throw;
            }

            return state;
        }
    }
}
