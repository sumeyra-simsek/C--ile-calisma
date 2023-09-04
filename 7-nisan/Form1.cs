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

namespace _7_nisan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte puan = byte.Parse(Interaction.InputBox("puanı giriniz"));
                if (puan > 100 || puan < 0) // puan 100 den buyukse yada 0 dan kucukse eger => yap
                    MessageBox.Show("0-100 arası değer giriniz!!!");
                else if (puan >= 50) MessageBox.Show("Geçtiniz :)");
                else MessageBox.Show("Kaldınız :(");

            }
            catch (OverflowException)
            { MessageBox.Show("byte sınırını aştınız!!!"); }
            catch (FormatException) // sayısal degıskene sayı degılde harf gırersen ortaya cıkan hata
            { MessageBox.Show("sayı giriniz!!!"); }
               
               
            
        }
    }
}
