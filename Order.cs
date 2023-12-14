using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Order : IPrintable
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        List<string> items = new List<string>();

        public Order(int id, DateTime orderDate, List<string> items)
        {
            throw new NotImplementedException();
        }

        public void AddItem()
        { throw new NotImplementedException(); }

        public void RemoveItem() 
        { throw new NotImplementedException(); }

        public void Print()
        { throw new NotImplementedException(); }
    }
}
