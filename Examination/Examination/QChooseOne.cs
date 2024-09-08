using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examination
{
    internal class QChooseOne : Question
    {
        public QChooseOne(int mark = 5,
            string header = "salah in the national team wear ",
            string choice1 = "10",
            string choice2 = "7",
            string choice3="11",
            string choice4="5") :base(mark,header)
        {
            this.choice1 = choice1;
            this.choice2 = choice2;
            this.choice3 = choice3;
            this.choice4 = choice4;
        }
        public override string ToString()
        {
            return $" \t marks on this question :  {this.Mark}\n" +
                $" \t the question {this.Header}\n" +
                $" \t  {this.choice1} \n" +
                $" \t  {this.choice2} \n" +
                $" \t  {this.choice3}  \n" +
                $" \t  {this.choice4} \n"
                ;
        }

        public string choice1 { get; set; }
        public string choice2 { get; set; }
        public string choice3 { get; set; }
        public string choice4 { get; set; }
    }
}
