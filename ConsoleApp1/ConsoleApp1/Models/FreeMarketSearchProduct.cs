using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public  class FreeMarketSearchProduct
    {
        public string keywords { get; set; }
        public Paging paging { get; set; }
        public List<Result> results { get; set; }
    }
    public class Paging
    {
        public int total { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }

    public class Setting
    {
        public string listing_strategy { get; set; }
    }

    public class Attributes
    {
        public string id { get; set; }
        public string name { get; set; }
        public string value_id { get; set; }
        public string value_name { get; set; }
    }

    public class Picture
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string status { get; set; }
        public string domain_id { get; set; }
        public Setting settings { get; set; }
        public string name { get; set; }
        public List<object> main_features { get; set; }
        public List<Attributes> attributes { get; set; }
        public List<Picture> pictures { get; set; }
        public string parent_id { get; set; }
        public List<object> children_ids { get; set; }
    }


}
