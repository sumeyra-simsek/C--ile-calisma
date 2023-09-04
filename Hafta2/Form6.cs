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
    public partial class Form6 : Form
    {
        Color[] renkler = {Color.Red,Color.Pink,Color.Purple,Color.Blue,Color.Magenta,Color.LightYellow,Color.Lavender,Color.MistyRose,
                          Color.Khaki,Color.Moccasin}; // renk dizisi tanımladık rastgele rakam gelecek sekilde asagıya kod yazacagız o rakamın indisine denk gelen renk dusecek.
        int sayac = 1;
        DialogResult cevap; // eger asagıda cevaba mesaj atarken türünü tanımlasaydık bi üstündeki ıf e baglı oldugu ıcın sadece o blokta calısırdı bu yuzzden global tanımladık cevap degıskenını
        Color tutrenk; // tutrenk adlı renk tutmasını ıstedıgmz degısknı olusturduk
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            tutrenk = this.BackColor; //arka plan rengini tutrenge aktardık en bastaki rengi 
        }

        private void Form6_Click(object sender, EventArgs e)
        {
            if (sayac == 1) // sayac 1 tanımladık yukarda. burdada eger 1 ise mesajı versın ıstıyoruz yani baslarken bize mesaj verecek
            cevap = MessageBox.Show("tıklanınca renk degişsin mi ?", "bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (cevap == DialogResult.Yes)
            {
                Random rnd = new Random(); // random sınıfından bir degısken olusturup buraya new randomdan rastgele sayı aktarıyor
                int sayi = rnd.Next(0, 10); // 0 10 arası random sayıyı sayı degıskenıne aktardı
                this.BackColor = renkler[sayi]; // sayı degıskenıne aktarılan sayıyı renkler dizisinde tanımladıgımız renge denk geleni arka plan rengi yaptık
                sayac++; // sayacı arttırdık 
                if (sayac == 5) { sayac = 1; this.BackColor = tutrenk; } // eger sayac 5 olduysa tekrar 1 e esitledik 5 defa da bir mesaj gelecek üstte yazdıgımız. sayac 5 olacak sonra tekrar 1 yaparken arkaplana tutrenktekı rengı aktarıyoruz yani en bastaki rengi.her tür sonu basladıgımızdaki rengi görmek istediğimz için boyle yaptık .

            }
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}
