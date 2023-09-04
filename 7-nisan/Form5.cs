using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_nisan
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
                listBox1.Items.Add(comboBox1.Items[i]);
            toolTip1.SetToolTip(comboBox1, "kayıt sayısı =" + comboBox1.Items.Count.ToString()); // combo ve listbox ın ustune gelınce balon cıkıyor o balona yazılmak ıstenenı burda belırttık.ancak propertıes ten tooltıp ın ısballoon ozelııgını true yap
            toolTip1.SetToolTip(listBox1, "kayıt sayısı =" + listBox1.Items.Count.ToString());
            toolStripLabel1.Text = "gözunuz burda olsun";
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "kayıt sayısı=" + listBox1.Items.Count.ToString();

        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "gözunuz burda olsun";
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (rbcombobox.Checked) comboBox1.Items.Add(tbeklenecekisim.Text);
            else if (rblistbox.Checked) listBox1.Items.Add(tbeklenecekisim.Text);
            else
            {
                comboBox1.Items.Add(tbeklenecekisim.Text);
                listBox1.Items.Add(tbeklenecekisim.Text);
            }
            toolTip1.SetToolTip(comboBox1, "kayıt sayısı =" + comboBox1.Items.Count.ToString());
            toolTip1.SetToolTip(listBox1, "kayıt sayısı =" + listBox1.Items.Count.ToString());
        }

        private void tbeklenecekisim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnekle_Click(sender, e);
        }

        private void tbaranan_TextChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.FindString(tbaranan.Text);
            comboBox1.SelectedIndex = comboBox1.FindString(tbaranan.Text);
        }
    }
}
