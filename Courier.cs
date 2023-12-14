using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Courier : IPerson, IPrintable
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Courier(string firstName, string lastName, string userID)
        {
            throw new NotImplementedException();
        }

        public void Print()
        { throw new NotImplementedException(); }
    }
}
