using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Contract
{
    public interface ISearchEngineConfiguration
    {
        int MaxResultCount { get; set; }
        string KeyApi { get; set; }
    }
}
