using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using SearchEngine.Contract;
using SearchWebApp.Models;

namespace SearchWebApp.DAL
{
    public class SearchEngineContext: DbContext
    {
        public SearchEngineContext() : base("DefaultConnection")
        {
        }

        public DbSet<SearchResultViewModel> SearchResults { get; set; }

        public override int SaveChanges()
        {
            UpdateDates();
            return base.SaveChanges();
        }

        private void UpdateDates()
        {
            foreach (var change in ChangeTracker.Entries<SearchResultViewModel>())
            {
                var values = change.CurrentValues;
                foreach (var name in values.PropertyNames)
                {
                    var value = values[name];
                    if (value is DateTime)
                    {
                        var date = (DateTime)value;
                        if (date < SqlDateTime.MinValue.Value)
                        {
                            values[name] = SqlDateTime.MinValue.Value;
                        }
                        else if (date > SqlDateTime.MaxValue.Value)
                        {
                            values[name] = SqlDateTime.MaxValue.Value;
                        }
                    }
                }
            }
        }
    }
}