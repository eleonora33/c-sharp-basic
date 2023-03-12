using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.CSharp.Basic._4.Class
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name,string academy,string group) {
            Name = name;
            Academy = academy;
            Group = group;
        }
    }
}

