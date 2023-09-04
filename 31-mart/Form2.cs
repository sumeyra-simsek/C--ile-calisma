using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_mart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 1; i <= 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(50);
            }
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
