﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    public class Customer : IPerson
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsVegetarian { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Customer(string firstName, string lastName, string phoneNumber, string address, bool isVegetarian)
        {
            throw new NotImplementedException();
        }

        public void MadeOrder()
        { throw new NotImplementedException(); }

        public void DeleteOrder()
        { throw new NotImplementedException(); }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
