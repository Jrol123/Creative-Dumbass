using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream main = new FileStream("C:/Users/Ученик/Desktop/USER/users.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(main);
            Boolean bol = false;
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(password.Text);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string F = "";
            foreach(int i in tmpHash)
            {
                F += i;
            }
            main.Seek(0, SeekOrigin.Begin);
            while (!reader.EndOfStream)
            {
                string loginn = reader.ReadLine();
                string passwordd = reader.ReadLine();
                if ((passwordd == F) && (loginn == login.Text))
                {
                    bol = true;
                    MessageBox.Show("S U C S E S S");
                    break;
                }
            }
            if(!bol)
            {
                MessageBox.Show("F A I L");
            }
            reader.Close();
            main.Close();
        }

        private void registr_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndex = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg2_Click(object sender, EventArgs e)
        {
            FileStream main = new FileStream("C:/Users/Ученик/Desktop/USER/users.txt", FileMode.OpenOrCreate);
            StreamWriter write = new StreamWriter(main);
            main.Seek(0, SeekOrigin.End);
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(textBox1.Text);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            write.WriteLine(textBox2.Text);
            for (int i = 0; i < tmpHash.Length;i++)
            {
                write.Write(tmpHash[i]);
            }
            write.Close();
            main.Close();
            MessageBox.Show("Sucsess");
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
