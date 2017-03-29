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
    }
}