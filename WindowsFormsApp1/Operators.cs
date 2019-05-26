using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Operators
    {
        private string op = null;

        public string get_op()
        {
            if(op != null && op.Length > 1)//на случай, если будет введено больше одного знака подряд
            {
                return op.Last().ToString();
            }
            else
            {
                return op;
            }          
        }

        public string set_op(string input)
        {
            return op += input;
        }

        public void set_null()
        {
            op = null;
        }
    }
}
