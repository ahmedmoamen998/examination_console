using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class Student
    {
        public Student(string name="null", string id= "null")
        {
            Name = name;
            Id = id;
        }

        public string Name  { get; set; }
        public string Id{ get; set; }
        public override string ToString()
        {
            return $" \t name : {Name}\n  \t id --> {Id}";
        }
    }
}
