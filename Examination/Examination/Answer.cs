using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class Answer
    {
        public Answer(int answer )
        {
            this.answer = answer;
        }
        public override string ToString()
        {
            return $"your  answer is{this.answer}";
        }
        public int answer{ get; set; }
        public override bool Equals(object? obj)
        {
            Answer TrueAnswer= (Answer)obj;
            return this.answer == TrueAnswer.answer ;
        }
    }
}
