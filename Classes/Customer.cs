﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        public int Id { get; set; }

        private string _firstName;
        public string FirstName { get; set; }

        //public string FirstName 
        //{
        //    get { return "Sayın " + _firstName; }
        //    set { _firstName = value; }
        //}

        // public string FirstName;  -  bu şekilde de yazdığımızda okuma yazma yapabiliyoruz. AMA !! yukarıdaki gibi get ve seti özelleştiremeyiz !

        public string LastName { get; set; }
        public string City { get; set; }

    }
}