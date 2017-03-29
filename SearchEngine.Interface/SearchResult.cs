using System;

namespace SearchEngine.Contract
{
    public class SearchResult
    {
        string SearchEngineName { get; set; }
        string Subject { get; set; }
        string Url { get; set; }
        string Text { get; set; }
        DateTime Published { get; set; }
        string RawDara { get; set; }
    }
}
