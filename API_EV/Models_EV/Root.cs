using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_EV.Models_EV
{
    //public class Root
    //{
    //    public int count { get; set; }
    //    public string next { get; set; }
    //    public object previous { get; set; }
    //    public List<Result> results { get; set; }
    //}
   
    public class Root
    {
        public List<Product> products { get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }


}