using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class CreateComponent
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idTemplate { get; set; }
        public int idState { get; set; }
        public string state { get; set; }
        public List<Attribute> attributes { get; set; }
    }

    public class Attribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}
