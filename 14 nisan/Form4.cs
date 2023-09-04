using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_nisan
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1) // tek karakterli yazıya yapılacak 
            {
                string ilk = textBox1.Text.Substring(0, 1); // yazılan kelimeyi sıfırdan ıtıbaren bir tane al dedik bu kodla.yanı ilk karakterı alıp ilk adlı degıskene aktardık
                ilk = ilk.ToUpper(); // buyuk harfe cevırıp tekrar ilk e aktardık 
                textBox1.Text = ilk; // ve bunu textboxa aktardık

                textBox1.Select(textBox1.Text.Length, 1);// ımlecı sona konumlandır.bunu yazmayınca ılk harfı yazıp ımlecı one getırıyor garıp 
            }
        }
    }
}
