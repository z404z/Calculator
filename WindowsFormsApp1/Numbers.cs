using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Numbers
    {
        private string str = "";

        public string get_num()
        {
            return str;
        }

        public string set_num(string input)
        {
            str += input;
            return str;
        }

        public void negate()
        {
            string number = get_num();
            if (number.Contains("-"))
            {
                str = number.Replace("-", "");
            }
            else
            {
                str = number.Insert(0, "-");
            }
        }
        
        public void set_null()
        {
            str = null;
        }
    }
}
