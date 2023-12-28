using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Order : IPrintable, ICloneable
    {
        public int Id { get; set; }
        public Courier Courier { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> Items;

        public Order(int id, DateTime orderDate,Courier courier, List<string> items)
        {
            Id= id;
            OrderDate = orderDate;
            Courier = courier;
            Items = items;
        }

        public void AddItem(string item)
        { 
            Items.Add(item);
        }

        public bool RemoveItem(string item) 
        {
            if(Items.Contains(item))
            {
                Items.Remove(item);
                return true;
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
		public override string ToString()
		{
			string result= $"id замовлення:{Id}\nДата замовлення:{OrderDate.ToString("dddd, dd MMMM yyyy")}\nid кур'єра:{Courier.FirstName}\nПозиції:\n";
			foreach (string item in Items)
				result+=(item + " ");
            return result;
		}

		public object Clone()
		{
			return new Order(Id, OrderDate,Courier, Items);
		}
	}
}
