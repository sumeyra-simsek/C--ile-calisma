using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ControlBox == true)
            {
            this.Text = " ";
            this.MinimizeBox = this.MaximizeBox = this.ControlBox = false;
            button1.Text = "control box göster";
            }
            else
            {
                this.Text = "ilk uygulama";
                this.MinimizeBox = this.MaximizeBox = this.ControlBox = true;
                button1.Text = "control box gizle";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Visible == true)
            {
                label1.Visible = false;
                button2.Text = "göster";
            }
            else
            {
                label1.Visible = true;
                button2.Text = "gizle";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("programa hoşgeldiniz ^-^");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK) this.BackColor = colorDialog1.Color;
        }
    }
}
