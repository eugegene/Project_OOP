using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Customer : Person
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _address;
        public override string FirstName { get=>_firstName; set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                _firstName = value;
            } }
        public override string LastName { get=>_lastName; set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException(nameof(value));
				_lastName = value;
			}
		}
		public string PhoneNumber { get => _phoneNumber; set=>_phoneNumber=value; }
		public string Address { get=>_address; set=>_address=value; }
        public List<Order> Orders;

		public Customer(string firstName, string lastName, string phoneNumber, string address)
        {
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Address = address;
            Orders = new List<Order>();
		}

        public virtual void MadeOrder(Order order)
        {
            Orders.Add(order);
        }

        public bool DeleteOrder(Order order)
        { 
            if (Orders.Contains(order))
            {
                Orders.Remove(order);
                return true;
            }
            return false;
        }

        public override string GetInfo()
        {
            string result = $"Ім'я: {FirstName}\nПрізвище:{LastName}\nНомер телефону:{PhoneNumber}\nАдреса:{Address}\nНе веган\nЗамовлення:\n";
            foreach(Order item in Orders)
            {
                result += item.ToString();
            }
            return result;
        }
    }
}
