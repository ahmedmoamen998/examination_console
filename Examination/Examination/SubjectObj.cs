using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class SubjectObj
    {



        public SubjectObj(string nameOfSubject = "",
            string nameOfDoctor = ""
          )
        {
            NameOfSubject = nameOfSubject;
            NameOfDoctor = nameOfDoctor;
            Console.WriteLine($"\n \t the name of doctor : {nameOfDoctor}");
            Console.WriteLine($" \t the name of subject : {nameOfSubject}");
        }

        public List<Question> q { get; set; }
        public string NameOfSubject { set; get; }
        public string NameOfDoctor { get; set; }

    }
}
