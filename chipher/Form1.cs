using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chipher
{
    public partial class Form1 : Form
    {
        int g = -1;
        char[] alph = new char[] { 'А', 'а', 'Б', 'б', 'В', 'в', 'Г', 'г', 'Д', 'д', 'Е', 'е', 'Ё', 'ё', 'Ж', 'ж', 'З', 'з', 'И', 'и', 'Й', 'й', 'К', 'к', 'Л', 'л', 'М', 'м', 'Н', 'н', 'О', 'о', 'П', 'п', 'Р', 'р', 'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц', 'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ', 'Ъ', 'ъ', 'Ы', 'ы', 'Ь', 'ь', 'Э', 'э', 'Ю', 'ю', 'Я', 'я', ' ', '.', ',', '?', '!', '-' };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = Convert.ToInt32(textBox1.Text);
            List<char> end = new List<char> { };
            char[] elv = text.Text.ToCharArray();
            
            for(int i = 0; i < elv.Length;i++)
            {
                for (int c = 0; c < alph.Length; c++)
                {
                    if(elv[i] == alph[c])
                    {
                        int a = c+f;

                        while(a > alph.Length - 1)
                        {
                            a -= alph.Length;
                        }
                        end.Add(alph[a]);

                        break;
                    }
                }
            }
            char[] endd = new char[end.Count];
            for (int i = 0; i < end.Count; i ++)
            {
                endd[i] = end[i];
            }

            string lol = new string(endd);
            chipher.Text = lol;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<char> end = new List<char> { };
            int f = -Convert.ToInt32(textBox1.Text);
            char[] elv = chipher.Text.ToArray();

            for (int i = 0; i < elv.Length; i++)
            {
                for (int c = 0; c < alph.Length; c++)
                {
                    if (elv[i] == alph[c])
                    {
                        int a = c + f;

                        while (a > alph.Length - 1)
                        {
                            a -= alph.Length;
                        }
                        end.Add(alph[a]);
                        break;
                    }
                }
            }
            char[] endd = new char[end.Count];
            for (int i = 0; i < end.Count; i++)
            {
                endd[i] = end[i];
            }
            string lol = new string(endd);
            text.Text = lol;
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void chipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
