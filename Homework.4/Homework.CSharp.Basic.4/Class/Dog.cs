using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.CSharp.Basic._4.Class
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public string Eat()
        {

            return $"The dog {Name} is now eating";
        }
        public string Play()
        {
            return $" The dog {Name} is now playing";
        }
        public string ChaseTail()
        {
            return "Dog is now chasing its tail";
        }
    }
}
