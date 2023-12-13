using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        List<string> items = new List<string>();
    }
}
