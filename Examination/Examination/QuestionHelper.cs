using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class QuestionHelper
    {
        public static List <Answer> display(List<Question> questions)

        {
            List<Answer> a = new List<Answer>(); 
            
            foreach (var item in questions)
            {
                
                Console.WriteLine(item.ToString() +"\n select answer   " );
                Console.WriteLine("enter answer ");
                a.Add(new Answer (int.Parse(Console.ReadLine())));
                
                
            }
            return a;
        }

       
        // implement a polymorphism
        internal static Question AddQuestionChoice(int mark=10,
            string head = "salah in the national team wear ",
            string choice1 = "10",
            string choice2 = "7",
            string choice3 = "11",
            string choice4 = "5")
        {
            Question q = new QChooseOne(mark,head,choice1,choice2,choice3,choice4);
            Console.WriteLine("\n\n\n\n\n\n\n\nthe question is added");
            return q; 
        }

        // implement a polymorphism
        internal static Question AddQuestionTrueOrFalse(int mark=5,
                                      string head="there is 10 fingers in one hand "
                                     )
        {
            Question q = new True_or_False(mark,head);
            Console.WriteLine("\n\n\n\n\n\n\n\nthe question is added");
            return q; 
        }

        internal static int NumOfQuestion(List<Question> l)
        {
            int NumOfQuestion=0;

            foreach (var item in l)
            {
                NumOfQuestion++; 
            }
            return NumOfQuestion; 
        }
        internal static int   NumOfMarks(List<Question> l)
        {
            int NumOfmarks = 0;

            foreach (var item in l)
            {
                NumOfmarks+=item.Mark;
            }

            return NumOfmarks;
        }

    }
}
