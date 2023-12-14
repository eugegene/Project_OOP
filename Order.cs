using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Order : IPrintable
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime OrderDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<string> items;

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
