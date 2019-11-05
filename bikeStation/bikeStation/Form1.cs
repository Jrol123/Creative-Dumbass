using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            bool lol = tabPage1.CanSelect;
            int a = 0;
            int b = 1;
            int f = tabControl1.SelectedIndex;
            //tabControl1.TabPages[1];
        }
    }
}
