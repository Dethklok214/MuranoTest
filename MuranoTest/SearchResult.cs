using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuranoTest
{
    public class SearchResult
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public int SearchRequestId { get; set; }
        public SearchRequest SearchRequest { get; set; }
    }
}
