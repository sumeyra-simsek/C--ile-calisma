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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btntersyaz_Click(object sender, EventArgs e)
        {
            string tutters = " ";
            string metin = tbyazi.Text; // metin degıskenınde tbyazı textboxına yazdıgımız yazıyı tuttuk
            for (int i = metin.Length - 1; i >= 0; i--) // metinlenght yazının harf sayısı. eörn 3 ise 2 yi i ye aktarıyoruz.
                tutters += metin[i]; // sonra o 2, metin dizisinin (strıng aynı zmanda dizi) 2 ındexlı harfı oluyor.zaten 3 harflı dedık 0 1 2 yanı son harfını tutterse aktardık.sonra ust satırdan i yi eksıltıp 1 ındıxı aktardık derken tersını yazmıs olduk.
               tbtersten.Text = tutters; // textbox a aktarıyoruz tek tek 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // btnkelimeler.Text = "kelimelere \n ayır";
            btnkelimeler.Text = "kelimelere" + Environment.NewLine + " ayır";
        }

        private void btnkelimeler_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string metin = tbyazi.Text; //metin degıskenıne yazıyı aktardık
            string[] kelimeler; // dizi tanımladık adı kelımeler
            kelimeler = metin.Split(' '); // bosluga gore parcala/böl yaptık.parcalanan yazıyı kelimeler dizisine aktar
            int i = 0;
            foreach (string herbirkelime in kelimeler) // herbirkelime degıskenıne kelımeler dızısını aktarıyoruz.
                listBox1.Items.Add(++i + ".kelime:" + herbirkelime); 
                
        }

        private void btnalgstr_Click(object sender, EventArgs e)
        {
            try
            {
                int nereden = int.Parse(nudnereden.Value.ToString()); //numerıc te secılenı nereden deg.ne aktardık
                int kactane = int.Parse(nudkactane.Value.ToString()); // numerıckactane de secılen sayıyı da (text yerıne value derız strıng old ıcın) kactane deg.ne aktardık
                tbtersten.Text = tbyazi.Text.Substring(nereden, kactane); // substrıng ıle nereden ıtıbaren kactane alınacagını hesapladık.ıkıncı textboxa aktardık.bellı bır konumdan ıtıbaren strıngın bır kısmını almak ıcın substrıng
            }
            catch { MessageBox.Show("sınır taşması!!!"); }
        }
    }
}
