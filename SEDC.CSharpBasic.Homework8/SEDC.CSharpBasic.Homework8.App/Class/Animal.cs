using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharpBasic.Homework8.App.Class
{
    public class Animal
    {
        public string Name { get; set; }    
        public string Color { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Animal(string name, string color, int age, Gender gender) { 
            Name = name;
            Color = color;
            Age = age;
            Gender = gender;
        }
    }
    
}
