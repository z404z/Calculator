using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillNumList();
            expression.Visible = false;
        }

        //Calc calc;
        //string action = "";
        
        List<Numbers> numList = new List<Numbers>(2);
        Operators ops = new Operators();

        private void fillNumList()
        {
            numList.Add(new Numbers());
            numList.Add(new Numbers());
        }

        //Кнопки цифровые
        //Если пользователь не выбрал операцию - заполняем первую переменную
        //Если пользователь выбрал операцию - заполняем вторую
        private void button1_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("1");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("1");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("2");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("2");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("3");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("3");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("4");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("4");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("5");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("5");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("6");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("6");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("7");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("7");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("8");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("8");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("9");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("9");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].set_num("0");
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].set_num("0");
                textBox1.Text = numList[1].get_num();
            }
        }
        private void negative_Click(object sender, EventArgs e)
        {
            if (ops.get_op() == null)
            {
                numList[0].negate();
                textBox1.Text = numList[0].get_num();
            }
            else
            {
                numList[1].negate();
                textBox1.Text = numList[1].get_num();
            }
        }

        //Кнопки операций
        //Если есть две переменные, при установке знака, 
        //при установке знака происходит вычисление выражения,
        //результат оказывается в первой переменной, ставится знак,
        //иначе просто ставим знак
        private void sum_Click(object sender, EventArgs e)
        {
            //string operation = ops.set_op("+");
            if (numList[0].get_num() != "" && numList[1].get_num() != "")
            {
                //выясняем значение уже имеющейся операции
                //результат пишем в первую переменную
                calculate();
                //ставим знак
                string operation = ops.set_op("+");

            }
            else
            {
                string operation = ops.set_op("+");
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            //string operation = ops.set_op("-");
            if (numList[0].get_num() != "" && numList[1].get_num() != "")
            {
                //выясняем значение уже имеющейся операции
                //результат пишем в первую переменную
                calculate();
                //ставим знак
                string operation = ops.set_op("-");

            }
            else
            {
                string operation = ops.set_op("-");
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            //string operation = ops.set_op("/");
            if (numList[0].get_num() != "" && numList[1].get_num() != "")
            {
                //выясняем значение уже имеющейся операции
                //результат пишем в первую переменную
                calculate();
                //ставим знак
                string operation = ops.set_op("/");

            }
            else
            {
                string operation = ops.set_op("/");
            }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            
            if (numList[0].get_num() != "" && numList[1].get_num() != "")
            {
                //выясняем значение уже имеющейся операции
                //результат пишем в первую переменную
                calculate();
                //ставим знак
                string operation = ops.set_op("*");

            }
            else
            {
                string operation = ops.set_op("*");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            numList[0].set_null();
            numList[1].set_null();
            ops.set_null();
            textBox1.Text = "";
        }
        private void count_Click(object sender, EventArgs e)
        {
            calculate();
        }
        //необходимо додумать появление исключений ввода
        private void calculate()
        {
            int a = Int32.Parse(numList[0].get_num());      //вот как мне тут исключение поймать?
            int b = Int32.Parse(numList[1].get_num());      //вот как мне тут исключение поймать?
            string op = ops.get_op();
            string result;
            ///
            Calc calculate = new Calc();
            ///
            calculate.set_first(a);
            calculate.set_second(b);
            calculate.set_op(op);
            ///
            result = calculate.calculate().ToString();
            ///
            numList[0].set_null();
            numList[1].set_null();
            ops.set_null();
            ///
            numList[0].set_num(result);//результат сразу становится первой переменной для дальнейших вычислений 
            numList[1].set_null();     //обнуляем, для дальнейших вычислений. далее будут вводиться только вторая переменная
            textBox1.Text = result;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void expression_Click(object sender, EventArgs e)
        {

        }
    }
}
