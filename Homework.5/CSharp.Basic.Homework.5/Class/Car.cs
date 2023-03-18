using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basic.Homework._5.Class

{
    public class Driver
    {
        public string Name { get; set; }
        public int Level { get; set; }

    }

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {

            return Driver.Level * Speed;

        }
    }
}

