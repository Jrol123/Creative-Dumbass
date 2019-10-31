using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> nums = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nums.Add("1");
            label1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nums.Add("4");
            label1.Text += "4";
        }
        int num = 0;
        int i = 0;
        int num1 = 0;
        int num2 = 0;
        bool stat = false;

        private void result_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            List<char>somt = new List<char>();
            

            foreach (string n in nums)
            {
                if (int.TryParse(n, out int ext))
                {
                    num *= 10;
                    num += ext;
                }
                else
                {
                    numbers.Add(num);
                    num = 0;
                    char [] f = n.ToArray();
                    somt.Add(f[0]);
                    i++;
                }
            }
            if(num != 0)
            {
                numbers.Add(num);
            }
            for(int d = 0; d < numbers.Count - 1; d ++)
            {
                if(!stat)
                {
                    num1 = numbers[d];
                    num2 = numbers[d + 1];
                    stat = true;
                }
                else
                {
                    num2 = numbers[d+1];
                }
                switch(somt[d])
                {
                    case '+':
                        num1 += num2;
                        break;
                    case '-':
                        num1 -= num2;
                        break;
                    case '*':
                        num1 *= num2;
                        break;
                    case '/':
                        num1 /= num2;
                        break;
                }

            }
            label1.Text = num1 + "";
            numbers.Clear();
            numbers.Add(num1);
            nums.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void twoBT_Click(object sender, EventArgs e)
        {
            nums.Add("2");
            label1.Text += "2";
        }

        private void threeBT_Click(object sender, EventArgs e)
        {
            nums.Add("3");
            label1.Text += "3";
        }

        private void fiveBT_Click(object sender, EventArgs e)
        {
            nums.Add("5");
            label1.Text += "5";
        }

        private void sixBT_Click(object sender, EventArgs e)
        {
            nums.Add("6");
            label1.Text += "6";
        }

        private void sevenBT_Click(object sender, EventArgs e)
        {
            nums.Add("7");
            label1.Text += "7";
        }

        private void eightBT_Click(object sender, EventArgs e)
        {
            nums.Add("8");
            label1.Text += "8";
        }

        private void nineBT_Click(object sender, EventArgs e)
        {
            nums.Add("9");
            label1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nums.Add("0");
            label1.Text += "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nums.Add("+");
            label1.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            nums.Add("-");
            label1.Text += "-";
        }

        private void umn_Click(object sender, EventArgs e)
        {
            nums.Add("*");
            label1.Text += "*";
        }

        private void del_Click(object sender, EventArgs e)
        {
            nums.Add("/");
            label1.Text += "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
