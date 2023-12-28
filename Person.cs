using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public abstract class Person
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public abstract string GetInfo();
    }
}
