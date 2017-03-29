using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SearchEngine.Contract;

namespace SearchWebApp.Models
{
    public class SearchResultViewModel: SearchResult
    {
        public int Id { get; set; }
        public string SearchWords { get; set; }

        public SearchResultViewModel(string searchWords, SearchResult searchResult)
        {
            Published = searchResult.Published;
            RawDara = searchResult.RawDara;
            SearchEngineName = searchResult.SearchEngineName;
            Subject = searchResult.Subject;
            Text = searchResult.Text;
            Url = searchResult.Url;
            SearchWords = searchWords;
        }
    }
}