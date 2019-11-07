using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void secund_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int hor = 0;
            int min = 0;
            int sec = 0;
            while (1!=2)
            {
                sec++;
                if (sec >= 60)
                {
                    sec = 0;
                    min++;
                    if (min >= 60)
                    {
                        min = 0;
                        hor++;
                        if (hor >= 12)
                        {
                            hor = 0;
                        }
                    }
                }
                if (sec < 10)
                {
                    secund.Text = "0";
                    secund.Text += hor.ToString();
                    if (min < 10 && min.ToString() != minut.Text)
                    {
                        minut.Text = "0";
                        minut.Text += hor.ToString();
                        if (hor < 10 && hor.ToString() != hour.Text)
                        {
                            hour.Text = "0";
                            hour.Text += hor.ToString();
                        }
                        else if (hor.ToString() != hour.Text)
                        {
                            hour.Text = hor.ToString();
                        }
                    }
                    else if (min.ToString() != minut.Text)
                    {
                        minut.Text = hor.ToString();
                        if (hor < 10 && hor.ToString() != hour.Text)
                        {
                            hour.Text = "0";
                            hour.Text += hor.ToString();
                        }
                        else if (hor.ToString() != hour.Text)
                        {
                            hour.Text = hor.ToString();
                        }
                    }
                }
                else if (sec.ToString() != secund.Text)
                {
                    secund.Text = hor.ToString();
                    if (min < 10 && min.ToString() != minut.Text)
                    {
                        minut.Text = "0";
                        minut.Text += hor.ToString();
                        if (hor < 10 && hor.ToString() != hour.Text)
                        {
                            hour.Text = "0";
                            hour.Text += hor.ToString();
                        }
                        else if (hor.ToString() != hour.Text)
                        {
                            hour.Text = hor.ToString();
                        }
                    }
                    else if (min.ToString() != minut.Text)
                    {
                        minut.Text = hor.ToString();
                        if (hor < 10 && hor.ToString() != hour.Text)
                        {
                            hour.Text = "0";
                            hour.Text += hor.ToString();
                        }
                        else if (hor.ToString() != hour.Text)
                        {
                            hour.Text = hor.ToString();
                        }
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void Form1_Initialize(object sender, EventArgs e)
        {
            
        }
    }
}
