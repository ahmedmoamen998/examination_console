using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class AnswerHelper
    {
        internal static void DisplayStudentAnswer(List<Answer> l )
        {
            foreach (var item in l)
            {
                Console.WriteLine(item.ToString()); 
            }

        }

        internal static void DisplayRightAnswer(List<Answer> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item.ToString());
            }

        }

        internal static int  TheMarks(List<Answer>ListOfstudent, List<Answer>ListOfTrue,List<Question>ListQuestions)
     { 
            List<int> marks = new List<int>();
             int i = 0; 
            foreach (var item in ListOfTrue)
            {
                       
                if (item.Equals(ListOfTrue[i]))
                {
                    marks.Add(ListQuestions[i].Mark);                     
                }

                ++i; 
            }
            return marks.Sum();      
    }
        internal Answer AddAnswerChoice(int choice)
        {
            Answer A= new Answer(choice);
            return A; 

        }

    }
}
