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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnyazıtipi_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog()) // fontdialog u göster ok denmısse yap 
                textBox1.Font = fontDialog1.Font; // fonttan secılen fontu textbox fontuna aktardık.
                
        }

        private void btnyazırengi_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void btnkalın_Click(object sender, EventArgs e)
        {
            Font eski = textBox1.Font;
            textBox1.Font = new Font(eski, FontStyle.Bold ^ eski.Style); // textbox ın fontuna aktar new font (eski degiskenıne eski fontu kaydettık eskının yerıne, bold yazı tıpı yanı kalın aktarılacak ama bold^eskinin style dedik cunku: eger ^eskı.style demeseydık onceden kalın olan yazıya bı etkısı olmuyor.(bold ıslemı her zaman 1 eski style eger onceden zaten bold ıse 1 oluyor. 1 xor 1 = 0 yani bold özellıgını kaldır.eger eskısı bold degılse 0 1 xor 0 ıse 1 bold yap. )
            //1 XOR 0=1 , 1 XOR 1=0 , 0 XOR 1=1 , 0 XOR 0=0
        }

        private void btnegik_Click(object sender, EventArgs e)
        {
            Font eski = textBox1.Font;
            textBox1.Font = new Font(eski, FontStyle.Italic ^ eski.Style);
        }

        private void btnaltıcizgili_Click(object sender, EventArgs e)
        {
            Font eski = textBox1.Font;
            textBox1.Font = new Font(eski, FontStyle.Underline ^ eski.Style);
        }

        private void btnklınegik_Click(object sender, EventArgs e)
        {
            Font eski = textBox1.Font;
            textBox1.Font = new Font(eski, FontStyle.Bold^ FontStyle.Italic ^ eski.Style);
        }

        private void btnkes_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0) textBox1.Cut();
            else MessageBox.Show("Seçili alan yok !!!!");
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0) textBox1.Copy();
            else MessageBox.Show("Seçili alan yok !!!!");
        }

        private void btnyapıstır_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void btngerial_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
    }
}
