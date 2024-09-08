using System.Linq.Expressions;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace Examination
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            // this is just to add Question choics ;
            
            //questions.Add(questionHelper.AddQuestionChoice());
            


            
            // intial some values 

            #region
            List<Answer> AnswerListOfTheRight = new List<Answer>();
           
            List<Question> questions = new List<Question>();
           

            
            char c = '*';

            #endregion

            #region
            int NOfQuestion,
                Mark,
                mark;
        string Name,
                Id,
                Head,
                head,
                NameOfSubj=",,",
                NameOfteacher="ll",
                choice1, 
                choice2, 
                choice3,
                choice4;           
                        
            #endregion

            do
            { try{
                    //student 

                    #region 
                   
                    Console.WriteLine("\t\t\t\t\tselect s for student \n\n  " +
                        "\t\t\t\t\tselect t for teacher "
                        );
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\tto quit press q ");
                    c = '*';
                    
                    
                    char.ToLower(c = char.Parse(Console.ReadLine()));
                         

                    if (c != 'q')
                    {
                        switch (c)
                        {
                         
                            case 's':
                                // take name and id 
                                #region
                                Console.WriteLine(" \t hi student");
                                char c3 = '.';
                                Name = "";
                                Console.Write(" \t plz enter your name :");
                                Name = Console.ReadLine();
                                Id = "";
                                Console.Write(" \t plz enter your Id : ");
                                
                                Id = Console.ReadLine();
                                Student student = new Student(Name, Id);
                                #endregion

                                do
                                {

                                    try
                                    {
                                        
                                        Console.WriteLine("\n \t to have exam partial  select p \n ");
                                        Console.WriteLine(" \t to have  exam final select f \n ");
                                        Console.WriteLine(" \t to return press r  \n ");

                                        c3 = char.Parse(Console.ReadLine());
                                        char.ToLower(c3);

                                        switch (c3)
                                        {
                                            case 'f':

                                                     NOfQuestion = QuestionHelper.NumOfQuestion(questions);
                                                Final_Exam f = new Final_Exam(NOfQuestion, NameOfSubj, NameOfteacher, questions);
 break;
                                            case 'p':

                                                NOfQuestion = QuestionHelper.NumOfQuestion(questions);
                                                    Practice_Exam p = new Practice_Exam(NOfQuestion,NameOfSubj,NameOfteacher,questions,AnswerListOfTheRight,student);
                                                                                            
  break;
                                            case 'r':
                                                break;
                                            default:
                                                Console.WriteLine("press valid letter1 ");
                                                break;
                                        }
                                    }
                                    catch { Console.WriteLine("plz try valid letter2  "); }

                                } while (c3 != 'r');
                                break;
                            #endregion
                     //teacher 
                    case 't':
                     #region

                                char c2 = '.';
                                do
                                {

                                    #region
                                    try {
                                        Console.WriteLine("hi teacher");
                                        Console.WriteLine("to make exam partial select p \n ");
                                        Console.WriteLine("to make exam final select f \n ");
                                        Console.WriteLine("to return press r  \n ");
                                       c2 = char.Parse(Console.ReadLine());
                                        char.ToLower(c2);
                                        switch (c2)   
                                        {
                                            case 'f':
                                        
                                                Console.WriteLine("final exam ");
                                                
                                                // we can also to make a one char for all choices and replace r with q  but its only two bytes  :)
                                                char c4 = '.';
                                                Console.WriteLine("hi teacher whats your name ");
                                                NameOfteacher = Console.ReadLine();
                                                Console.WriteLine("hi teacher whats your subj ");
                                                NameOfSubj = Console.ReadLine();
                                                do
                                                {
                                                    try
                                                    {
                                                       
                                                        
                                                        Console.WriteLine("to make multiply question  m\n ");
                                                        Console.WriteLine("to make true or false   select h \n ");
                                                        Console.WriteLine("to return press r  \n ");

                                                        c4 = char.Parse(Console.ReadLine());
                                                        char.ToLower(c4);
                                                        switch (c4)
                                                        {
                                                            case 'm':
                                                                // enter the question 
                                                                #region
                                                                Console.WriteLine("multiply question ");
                                                                Console.WriteLine("what is the marks on this question");
                                                                 mark = int.Parse(Console.ReadLine());
                                                                Console.WriteLine("the question is ");
                                                                 head = Console.ReadLine();
                                                                
                                                                Console.WriteLine("first choice ");
                                                                 choice1  = Console.ReadLine(); 
                                                                Console.WriteLine("second choice ");
                                                                 choice2= Console.ReadLine(); 
                                                                Console.WriteLine("third choice ");
                                                                choice3 = Console.ReadLine(); 
                                                                Console.WriteLine("forth choice ");
                                                                 choice4 = Console.ReadLine();
                                                                #endregion 
                                                                var question11 = QuestionHelper.AddQuestionChoice(mark, head, choice1, choice2, choice3, choice4);
                                                               questions.Add(question11);
                                                                Console.WriteLine("enter the answer is ");
                                                                int answer = int.Parse(Console.ReadLine());
                                                                if (answer == 1 || answer == 2 || answer == 3 || answer == 4)
                                                                { AnswerListOfTheRight.Add(new Answer(answer)); }
                                                                else { Console.WriteLine("sorry please type invalid num 1/2/3/4"); }
                                                               
                                                                break;
                                                            #endregion

                                                            case 'h':

                                                                #region
                                                                Console.WriteLine("true or  question ");
                                                                Console.WriteLine("what is the marks on this question");
                                                                 Mark = int.Parse(Console.ReadLine());
                                                                Console.WriteLine("the question is ");
                                                                 Head = Console.ReadLine();
                                                                Console.WriteLine("true press 1");
                                                                Console.WriteLine("false press 2 ");
                                                                var question22 = QuestionHelper.AddQuestionTrueOrFalse(Mark, Head);
                                                                Console.WriteLine("the answer is ");
                                                                #endregion
                                                                Console.WriteLine("enter the correct answer ");
                                                                int answerh = int.Parse(Console.ReadLine());
                                                                if (answerh == 1 || answerh == 2)
                                                                { AnswerListOfTheRight.Add(new Answer(answerh)); }
                                                                else { Console.WriteLine("sorry please type invalid num 1/2"); }
                                                                break;
                                                            case 'r':
                                                                break;

                                                            default:
                                                                Console.WriteLine("press valid letter1 ");
                                                                break;
                                                        }



                                                    }
                                                    catch { Console.WriteLine("plz try valid letter2  "); }

                                                } while (c4 != 'r');
                                                break;
                                            case 'p':
                                                
                                                Console.WriteLine("partial exam ");
                                                char c5 = '.';
                                                Console.WriteLine("hi teacher whats your name ");
                                                NameOfteacher = Console.ReadLine();
                                                Console.WriteLine("whats is  name of subject ");
                                                NameOfSubj = Console.ReadLine();
                                                do
                                                {
                                                    try
                                                    {

                                                        Console.WriteLine("to make multiply question  m\n ");
                                                        Console.WriteLine("to make true or false  select h \n ");
                                                        Console.WriteLine("to return press r  \n ");

                                                        c5 = char.Parse(Console.ReadLine());
                                                        char.ToLower(c5);
                                                        switch (c5)
                                                        {
                                                            case 'm':
                                                                
                                                                #region 
                                                                Console.WriteLine("multiply question ");
                                                                Console.WriteLine("what is the marks on this question");
                                                                 mark = int.Parse(Console.ReadLine());
                                                                Console.WriteLine("the question is ");
                                                                 head = Console.ReadLine();
                                                                Console.WriteLine("first choice ");
                                                                 choice1 = Console.ReadLine();
                                                                 Console.WriteLine("second choice ");
                                                                  choice2 = Console.ReadLine();
                                                                
                                                                Console.WriteLine("third choice ");
                                                                 choice3 = Console.ReadLine();
                                                                Console.WriteLine("forth choice ");
                                                                 choice4 = Console.ReadLine();
                                                                #endregion

                                                                var question11 = QuestionHelper.AddQuestionChoice(mark, head, choice1, choice2, choice3, choice4);
                                                               
                                                                questions.Add(question11);

                                                                Console.WriteLine("the answer is" +
                                                                    "\n select 1 for first choice" +
                                                                    "\n select 2 for second choice" +
                                                                    "\n select 3 for third choice" +
                                                                    "\n select 4 for forth choice  ");
                                                                int answer = int.Parse(Console.ReadLine());
                                                                if (answer == 1 || answer == 2 || answer == 3 || answer == 4)
                                                                { AnswerListOfTheRight.Add(new Answer(answer)); }
                                                                else { Console.WriteLine("sorry please type invalid num 1/2/3/4"); }

                                                                break;

                                                            case 'h':  
                                                                #region
                                                                Console.WriteLine("\n\t\t\ttrue or false ");
                                                                Console.WriteLine("what is the marks on this question");
                                                                 Mark = int.Parse(Console.ReadLine());
                                                                Console.WriteLine("the question is ");
                                                                Head = Console.ReadLine();
                                                                Console.WriteLine("true press 1");
                                                                Console.WriteLine("false press 2 ");
                                                                var question22 = QuestionHelper.AddQuestionTrueOrFalse(Mark, Head);
                                                                int answerh = int.Parse(Console.ReadLine());
                                                                if (answerh == 1 || answerh == 2)
                                                                { AnswerListOfTheRight.Add(new Answer(answerh)); }
                                                                else { Console.WriteLine("sorry please type invalid num 1/2"); }
                                                                #endregion
                                                                questions.Add(question22);

                                                                AnswerListOfTheRight.Add(new Answer(int.Parse(Console.ReadLine())));
                                                                break;
                                                            case 'r':
                                                                break;

                                                            default:
                                                                Console.WriteLine("press valid letter1 ");
                                                                break;
                                                        }
                                                       
                                                       }
                                                    catch { Console.WriteLine("plz try valid letter2  "); }

                                                } while (c5 != 'r');
                                                break;
                                            case 'r': break;


                                            default:
                                                Console.WriteLine("press valid letter1 ");
                                                break;
                                        }
                                    }
                                    catch { Console.WriteLine("plz try valid letter2  "); }

                                } while (c2 != 'r');
                                #endregion
                         break;
                    default:
                        Console.WriteLine("No plz try again ");
                    break;
                    }
                    }
                }
                catch
                {Console.WriteLine("select valid choice ");}
            } while (c != 'q');
       }
    }
}