using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
	public class VegeterianCustomer:Customer
	{
		public VegeterianCustomer(string firstName, string lastName, string phoneNumber, string address):base(firstName, lastName, phoneNumber, address)
		{

		}
		public override void MadeOrder(Order order)
		{
			order.Items = order.Items.Where(u => u == "Домашній"|| u == "Гречаний" || u == "КремСуп" || u == "Кола" || u == "Спрайт" || u == "Фанта" || u == "Лимонад").ToList();
            Console.WriteLine("Видалено усі не-вегетаріанські страви");
            base.MadeOrder(order);
		}
		public override string GetInfo()
		{
			string result = $"Ім'я:{FirstName}\nПрізвище:{LastName}\nНомер телефону:{PhoneNumber}\nАдреса{Address}\nВеган\nЗамовлення:\n";
			foreach (Order item in Orders)
			{
				result += item.ToString();
			}
			return result;
		}
	}
}
