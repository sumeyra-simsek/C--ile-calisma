using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnsay_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(tbkactane.Text); // hangı sayıyı gırersek o maxımum oluyor once
            for (int i = 1; i <= int.Parse(tbkactane.Text); i++) // textbox ın ıcınde strıng bılgı saklıdır bu yuzden bunu ınt parse ıle ınt a cevırdık
            {
                label1.Text = i.ToString(); // girdigimiz sayı labelda yazsın ıstedık
                progressBar1.Value++;
                label1.Refresh(); // sayıyo hızlı hızlı labelda guzel bişi kaldırınca abuk sabuk gozukuyo 
                System.Threading.Thread.Sleep(40);
            }
                
        }

        
    }
}
