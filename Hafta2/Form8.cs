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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();  // formu bır ornege donusturmelıyız.cunku form bir classtır herhangı bir classı nesneye donusturmeden onu kullanamayız.artık bunu yaptıktan sonra form1 ı cagırabılırız form1 i f1 temsıl edıyor.
            f1.Show(); // bununla gösterdıgımızde form 8 ı de one alabılıyoruz butona tıklayarak actıgımız form1 ıde cekıp surukleyebılır-one alabılırız.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // bununla gösterdıgımızde arkadakı form8 ı one alamıyoruz.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide(); // arkadaki form8 i menuyu gizler
            f3.ShowDialog();
            this.Show(); // gizlediğimiz menuyu form3 u kapattıktan sonra gösterir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide(); 
            f4.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes) Application.Exit();
        } // contextmenustrıp ı formun loadından ayarla .menustrıp dırekt ekranda gozukuyor ama context ıcın sag tık yapmak lazım 
    }
}
