using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class Exam:SubjectObj
    {

        public Exam(int numOfQuestion,
            string nameOfSubject, 
            string nameOfDoctor ,
            List<Question> q  )
            :base( nameOfSubject, nameOfDoctor)
        {

            this.NumOfQuestion = numOfQuestion;
            
    date = DateTime.Now;
            Console.WriteLine($"\nthe date : {date}");
            Console.WriteLine($"the number of question : {numOfQuestion}");
           


        }


        public int NumOfQuestion { get; set; }
        public DateTime date { get; set; }
        

    }
}
