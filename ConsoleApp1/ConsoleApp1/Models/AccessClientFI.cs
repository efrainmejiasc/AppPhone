using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public  class AccessClientFI
    {
        public List<Datum> data { get; set; }
        public PagingFI paging { get; set; }
    }
    public class Datum
    {
        public string id { get; set; }
        public string login_url { get; set; }
        public string access_token { get; set; }
    }

    public class Cursors
    {
        public string before { get; set; }
        public string after { get; set; }
    }

    public class PagingFI
    {
        public Cursors cursors { get; set; }
    }
}
