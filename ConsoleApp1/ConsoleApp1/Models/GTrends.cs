using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class GTrends
    {
        public List<ComparisonItem> comparisonItem { get; set; }
        public int category { get; set; }
        public string property { get; set; }
    }

    public class ComparisonItem
    {
        public string keyword { get; set; }
        public string geo { get; set; }
        public string time { get; set; }
    }
}
