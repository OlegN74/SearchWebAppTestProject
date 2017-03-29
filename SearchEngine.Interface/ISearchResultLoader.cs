namespace SearchEngine.Contract
{
    public interface ISearchResultLoader
    {
        void Configure(string searchString, ISearchEngineConfiguration config);
        string LoadData();
    }
}
