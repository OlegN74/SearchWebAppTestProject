using System;

namespace SearchEngine.Contract
{
    public class SearchResult
    {
        public string SearchEngineName { get; set; }
        public string Subject { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public DateTime Published { get; set; }
        public string RawDara { get; set; }
    }
}
