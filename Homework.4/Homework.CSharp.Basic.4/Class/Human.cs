using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework.CSharp.Basic._4.Class
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string GetPersonStats()
        {
            return $"Human {FirstName} {LastName} is {Age}";
        }
    }
}


