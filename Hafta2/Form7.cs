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
    public partial class Form7 : Form
        
    {
        int bekle;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnyashesapla_Click(object sender, EventArgs e)
        {
            label2.Text = "Hesaplanıyor...";
            label2.Font = new Font(label2.Font.Name, 17, FontStyle.Bold); // sıze ını 17 yaptık label2font degısmedık tımes new roman vs.bold yaptık bırde o da kalın yazıydı sanırım
            int yas = DateTime.Now.Year - dtpdtarihi.Value.Year; // yası hesaplayan kod
            progressBar1.Maximum = yas; // yas kadar dongu donecek .maxı bu yuzden o kadar yaptık. eger yas 25 ıse ve maxı 100 ayarlarsak barın dortte bırı dolar maxı yas ayarlarsak barın ful oldugunu goruruz ıslem sonunda.ful gormek ıstıyoruz.
            for (int i=1;i<=yas;i++) //yas mıktarı kadar dongu donecek.yas ne kadar buyukse o kadar yavas hesaplanıyor gıbı bır goruntu cızmek ıstedık.
            {
                progressBar1.Value = i; // yesil hareketi bu yapıyor
                Random rnd = new Random();
                label2.Text = "Hesaplanıyor..." + rnd.Next(0, 100).ToString(); // bir animasyon goruntu saglamaya calıstık
                label2.Refresh(); //labelın ıcındekı bılgıyı temızlıyor. her dongude 1 yazı cıkıyor hazırlanıyor...34 gıbı sayıyı random ayarladık dongu sonu i artıyor ve tekrar yenı bır yazı belırıyor.bu yazıyı yazdıktan sonra temızlemelıyız kı sonrakını yazsın.bu ıslemlerı de alt satırda ayarladıgımız zaman aralıgındakı hızla göstermesını ıstedık.
                System.Threading.Thread.Sleep(50); // 50 milisaniye bekleyerek anımasyon tekrarlıyor
            }
            label2.Text = "Yaşınız = " + yas.ToString(); // donguden cıktık ve en son dongude sıralanan rastgele sayıları degılde yası göstermesını ıstıyoruz.
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text = "***Yaşınızı buradan takip edin***";
            label2.Font = new Font(label2.Font.Name, 10);
            btnyasgelsin.Enabled = false;
            bekle = trackbar.Value;
        }

        private void btnyasgitsin_Click(object sender, EventArgs e)
        {
            btnyasgitsin.Enabled = false;
            btnyasgelsin.Enabled = true;
            for (int i = 1; i <= 30; i++)
            {
                label2.Location = new Point(label2.Location.X + i, label2.Location.Y); // label 2 nin lokasyonunu ayarlıyoruz gidip gelme animasyonu ıcın 
                label2.Refresh();
                System.Threading.Thread.Sleep(bekle);

            }

        }

        private void btnyasgelsin_Click(object sender, EventArgs e)
        {
            btnyasgitsin.Enabled = true;
            btnyasgelsin.Enabled = false;
            for (int i = 1; i <= 30; i++)
            {
                label2.Location = new Point(label2.Location.X - i, label2.Location.Y); // gıttıgı yolu gerı gelmeli. yukardaki +i yi -i yaptık burda
                label2.Refresh();
                System.Threading.Thread.Sleep(bekle);

            }

        }

        private void trackbar_ValueChanged(object sender, EventArgs e) // trackbarın bu ozellıgını eventsdan sectık valuse degısımı ıcın
        {
            textbox.Text = trackbar.Value.ToString(); // trackbarda degıstırdgımız degerı textbox ın textıne aktardık
            bekle = trackbar.Value;
                
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e) // textbox ın tus olayı ıcın bu ozellık
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    trackbar.Value = int.Parse(textbox.Text); // eger (enter a basılırsa) yap => trackbara textbox taki degeri aktar
                    bekle = trackbar.Value;
                }
            }
            catch
            { MessageBox.Show("10-300 arası sayı giriniz!!!"); }

        }

        private void btnyasrengi_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); // renk paletını ac
            label2.ForeColor = colorDialog1.Color; // secılenı label2 ye aktar
        }
    }
}
