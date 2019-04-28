using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuranoTest
{
    public class SearchContext : DbContext
    {
        public SearchContext() : base("DBConnection")
        { }

        public DbSet<SearchRequest> requests { get; set; }
        public DbSet<SearchResult> results { get; set; }
    }
}
