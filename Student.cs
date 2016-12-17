using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Student
    {
        public string Name { get; set; }
        public Book Book { get;  set; }

        public Student(string Name)
        {
            this.Name = Name;
        }
    }
}
