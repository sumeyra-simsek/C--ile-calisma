using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Hafta2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnveri_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbadet.Text); 
            int toplam = 0;
            progressBar1.Maximum = x;
            for (int i = 1; 1 <= x; i++)
            {
                int puan = int.Parse(Interaction.InputBox(i.ToString() + ". degeri giriniz"));
                toplam += puan;
                progressBar1.Value = i;
            }
            float ortalama = (float)toplam / x;
            tbort.Text = ortalama.ToString();

        }
    }
}
