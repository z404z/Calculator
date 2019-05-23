using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calc
    {
        private int first;
        private int second;
        private string op;

        public int set_first(int num)
        {
            first = num;
            return first;
        }

        public int get_first()
        {
            return first;
        }

        public int set_second(int num)
        {
            second = num;
            return second;
        }

        public int get_second()
        {
            return second;
        }

        public string set_op(string operation)
        {
            op = operation;
            return op;
        }

        public string get_op()
        {
            return op;
        }


        ////public Calc()
        ////{
        ////    inputArray = new string[0];
        ////}

        //public void parse(string numbers)
        //{
        //    //int size = numbers.Length;
        //    bool nextVar = false;
        //    foreach (char n in numbers)
        //    {
        //        if ((n.ToString() is "+") || (n.ToString() is "-") || (n.ToString() is "/") || (n.ToString() is "*"))
        //        {
        //            nextVar = true;
        //            op = n.ToString();
        //            continue;
        //        }
        //        if (nextVar == false)
        //        {
        //            first += n.ToString();
        //        }
        //        if (nextVar == true)
        //        {
        //            second += n.ToString();
        //        }
        //    }

        //}


        //private void parseArray(string numbers)
        //{
        //    List<string> list = new List<string>();
        //    /*
        //    list.Add("one");
        //    list.Add("two");
        //    list.Add("three");
        //    */
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        bool firstNum = false;
        //        bool secondNum = false;
        //        char symbol = numbers[i];
        //        //char nextSymbol = numbers[i + 1];

        //        if ((symbol.ToString() is "-") && i == 0)
        //        {
        //            first += symbol;
        //            firstNum = true;
        //        }

        //        if (((symbol.ToString() is "+") || (symbol.ToString() is "-") || (symbol.ToString() is "/") || (symbol.ToString() is "*")) && firstNum == true)
        //        {
        //            secondNum = true;
        //            op += symbol;
        //            continue;
        //        }
        //        if (secondNum == true)
        //        {

        //        }
        //    }
        //    string[] array = list.ToArray();
        //}


        public int calculate()
        {
            int result = 0;

            if (get_op() == "+") {
                int a = get_first();
                int b = get_second();
                result = a + b;           
            }

            if (get_op() == "-")
            {
                int a = get_first();
                int b = get_second();
                result = a - b;
            }

            if (get_op() == "*")
            {
                int a = get_first();
                int b = get_second();
                result = a * b;
            }

            if (get_op() == "/")
            {
                int a = get_first();
                int b = get_second();
                result = a / b;
            }

            return result;
        }

    }
    
}
