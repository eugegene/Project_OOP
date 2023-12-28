using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Courier : Person
    {
		private string _firstName;
		private string _lastName;
		public override string FirstName
		{
			get => _firstName; set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException(nameof(value));
				_firstName = value;
			}
		}
		public override string LastName
		{
			get => _lastName; set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException(nameof(value));
				_lastName = value;
			}
		}

		public Courier(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
