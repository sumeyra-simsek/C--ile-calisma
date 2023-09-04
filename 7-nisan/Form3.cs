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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            lbnumara2.Text = tbnumara1.Text;
            if (cbbolum1.SelectedIndex >= 0) lbbolum2.Text = cbbolum1.SelectedItem.ToString();
            
                
        }
    }
}
