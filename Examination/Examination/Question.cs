using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class Question
    {
        public string Header  { get; set; }
        public int Mark { get; set; }
        public Question(int mark =5 ,string header= "question")
        {
            this.Mark = mark;
            this.Header = header;
          
        }
        public override string ToString()
        {
            return $"\n\t\t\tthe marks on this question :  {this.Mark}\n" +
                $"\n {this.Header} ";
        }


    }
}
