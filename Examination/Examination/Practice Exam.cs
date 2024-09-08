using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class Practice_Exam:Exam
    {
        public Practice_Exam(int numOfQuestion,
                                string nameOfSubject,
                                string nameOfDoctor,
                                List<Question> q,
                               
                                List<Answer> lT,
                                Student s )
            : base(numOfQuestion, nameOfSubject, nameOfDoctor, q)
        {
            this.QP = q;


            this.LT = lT;
            List<Answer> AnswerListOfstudent = new List<Answer>();
            Console.WriteLine("\n\n\t\t\t\t\t hello in the practice exam");
            Console.WriteLine($" \t the number of question is  :  {numOfQuestion}");
            Console.WriteLine($" \t the total degree {QuestionHelper.NumOfMarks(q)}");
            AnswerListOfstudent=QuestionHelper.display(q);
            Console.WriteLine(s.ToString());
            Console.WriteLine($" \t your degree is : {AnswerHelper.TheMarks(AnswerListOfstudent, LT, QP)} of {QuestionHelper.NumOfMarks(q)}");

        }
        public List<Answer>LT{ get; set; }
        public List<Question> QP{ get; set; }

    }
}
