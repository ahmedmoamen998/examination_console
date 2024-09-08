    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    internal class True_or_False:Question
    {
        public True_or_False(int mark = 5, string header="1" ):base(mark,header)
        {
          
        }

        public override string ToString()
        {
            return base.ToString()+ "\n \t true   press 1" +
                                    "\n \t false  press 2 ";
        }

        public char choice { get; set; }
        
    }
}
