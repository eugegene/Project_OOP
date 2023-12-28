using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Restaurant
{
	public class UserMenu
	{
		public List<Courier> couriers;
		public List<Customer> customers;
		public Customer CurrentCustomer;
		public UserMenu()
		{
			couriers = new List<Courier>();
			customers = new List<Customer>();
			MainMenu();
		}
		public void MainMenu()
		{
            Console.WriteLine("1. Додати користувача");
            Console.WriteLine("2. Обрати користувача");
            Console.WriteLine("3. Зробити замовлення");
            Console.WriteLine("4. Видалити замовлення");
            Console.WriteLine("5. Найняти кур'єра");
            Console.WriteLine("6. Вивести список користувачів");
            Console.WriteLine("7. Вийти");

            try
            {
                Console.WriteLine();
				switch (Console.ReadLine())
				{
					case "1":
						AddCustomer();
						break;
					case "2":
						ChooseCustomer();
						break;
                    case "3":
						MakeOrder();
						break;
					case "4":
						DeleteOrder();
						break;
					case "5":
						HireCourier();
						break;
					case "6":
						RetrieveCustomers();
						break;
					case "7":
						Exit();
						break;
					default:
						throw new Exception("Неправильний вибір!");
				}

			}
			catch(Exception ex)
			{
				ReturnToMenu(ex);
			}
		}
		public void AddCustomer()
		{
            Console.WriteLine("Введіть ваше ім'я");
			string Name = Console.ReadLine();
			Console.WriteLine("Введіть ваше прізвище");
			string SurName=Console.ReadLine();
			Console.WriteLine("Введіть ваш номер телефону");
			string phonenumb = Console.ReadLine();
			Console.WriteLine("Введіть вашу адресу");
			string adress = Console.ReadLine();
			Console.WriteLine("Чи є ви вегетаріанцем? (1/0)");
			bool IsVegan = false;
			if (Console.ReadLine() == "1")
			{
				customers.Add(new VegeterianCustomer(Name, SurName, phonenumb, adress));
			}
			else 
				customers.Add(new Customer(Name, SurName, phonenumb, adress));
			ReturnToMenu();
		}
		public void ChooseCustomer()
		{
			for(int i = 0; i < customers.Count; i++)
			{
                Console.WriteLine(i + " " + customers[i].FirstName + " " + customers[i].LastName);
            }
			int choice=int.Parse(Console.ReadLine());
			CurrentCustomer= customers[choice];
		    ReturnToMenu();
		}
		public void MakeOrder()
		{
			if (CurrentCustomer == null)
				throw new Exception("Перед створенням замовлення оберіть користувача!");
			//if (couriers.Count == 0)
			//	HireCourier();
			int id = new Random().Next(10, int.MaxValue);
			Courier courier = couriers[new Random().Next(0, couriers.Count)];
			DateTime time = DateTime.Now;
			List<string> items= FoodChoice().Split(',', '(', ')').Where(u => !u.Equals("") && !u.Equals(" ")).ToList();
			CurrentCustomer.MadeOrder(new Order(id,time,courier,items));
			ReturnToMenu();
		}
		public void DeleteOrder()
		{
			if (CurrentCustomer == null)
				throw new Exception("Перед видаленням замовлення оберіть користувача!");
			if(CurrentCustomer.DeleteOrder(CurrentCustomer.Orders.LastOrDefault()))
			{
                Console.WriteLine("Видалено останнє замовлення");
				ReturnToMenu();
            }
			Console.WriteLine("Не знайдено замовлень");
			ReturnToMenu();
		}
		public string FoodChoice()
		{
			string result = "(";
			while (true)
			{
				Console.WriteLine("Оберіть бургер:\n0 - Пропустити, 1 - Гамбургер, 2 - Чізбургер, 3 - Фірмовий, 4 - Антибургер");
				switch (Console.ReadLine())
				{
					case "1":
						result += (Burgers)1 + ",";
						break;
					case "2":
						result += (Burgers)2 + ",";
						break;
					case "3":
						result += (Burgers)3 + ",";
						break;
					case "4":
						result += (Burgers)4 + ",";
						break;
					default:
						result += ",";
						break;
				}
				Console.WriteLine("Оберіть суп:\n0 - Пропустити, 1 - Домашній, 2 - Гречаний, 3 - Крем-Суп, 4 - Борщ");
				switch (Console.ReadLine())
				{
					case "1":
						result += (Soups)1 + ",";
						break;
					case "2":
						result += (Soups)2 + ",";
						break;
					case "3":
						result += (Soups)3 + ",";
						break;
					case "4":
						result += (Soups)4 + ",";
						break;
					default:
						result += ",";
						break;
				}
				Console.WriteLine("Оберіть напій:\n0 - Пропустити, 1 - Кола, 2 - Фанта, 3 - Спрайт, 4 - Лимонад");
				switch (Console.ReadLine())
				{
					case "1":
						result += (Drinks)1 + ",";
						break;
					case "2":
						result += (Drinks)2 + ",";
						break;
					case "3":
						result += (Drinks)3 + ",";
						break;
					case "4":
						result += (Drinks)4 + ",";
						break;
					default:
						result += ",";
						break;
				}
				result += ") ";
                Console.WriteLine("Додати ще? 1 - Так, 2 - Ні");
				if (Console.ReadLine() == "2")
					break;
            }
			return result;
		}
		public void RetrieveCustomers()
		{
			if (customers.Count == 0)
				throw new Exception("Немає користувачів");
			foreach (var customer in customers)
			{
				Console.WriteLine(customer.GetInfo());
			}
            ReturnToMenu();
        }
		public void HireCourier()
		{
			string id = Guid.NewGuid().ToString();
			Courier courier = new Courier(id, id);
			couriers.Add(courier);
            Console.WriteLine("Найнято кур'єра");
            ReturnToMenu();
		}
		public void ReturnToMenu()
		{
			Console.WriteLine("Натисніть Enter");
			Console.ReadLine();
			MainMenu();
		}
		public void ReturnToMenu(Exception ex)
		{
            Console.WriteLine(ex.Message);
			ReturnToMenu();
        }
		public void Exit()
		{
			Environment.Exit(0);
		}
	}
}
