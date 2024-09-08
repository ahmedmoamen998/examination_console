using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class Final_Exam:Exam
    {
        public Final_Exam(int numOfQuestion,
           string nameOfSubject,
           string nameOfDoctor ,
           List<Question> q 
           )
           : base(numOfQuestion, nameOfSubject, nameOfDoctor, q)
        {
        
            List<Answer> AnswerListOfstudent = new List<Answer>();
            Console.WriteLine("\n\n\t\t\t\t\t hello in the final  exam");
            Console.WriteLine($" \t the number of question is  :  {numOfQuestion}");
            Console.WriteLine($" \t the total degree {QuestionHelper.NumOfMarks(q)}");
            AnswerListOfstudent = QuestionHelper.display(q);
        }

    }
}
