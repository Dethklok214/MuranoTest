using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuranoTest
{
    public class SearchRequest
    {
        public int Id { get; set; }
        public string text { get; set; }
        public ICollection<SearchResult> SearchResult { get; set; }
    }
}
