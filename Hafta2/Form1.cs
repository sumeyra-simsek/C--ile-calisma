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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color tutarkaplanrengi, tutyazırengi; // bu değişkenleri tbnumaranın renk değişimi için kullanacagız.yapmak istediğimiz sey tbnumara aktif hale geldiğinde ve giriş yapıldıgında yazı değişecek ,bu işlemi tbnumara enter blogunda yaptık.ayrıldıgımızda eski rengine dönmesini istiyoruz bunun için color tipinde bu satırda class blogunda degişken tanımladık bu degişkenlere deger atamasını formun loadında atıyoruz bize o blokta tbnumaranın varsayılan renklerini veriyor.bize ilerde en bastaki renklerı lazım.sonra tbnumara leave blogunda bu içine renk atadıgımız degiskenleri kullanacagız.
        private void Form1_Load(object sender, EventArgs e)
        {
            tbnumara.Enabled = tbadsoyad.Enabled = false; // enabled özelliği secilen nesneyi pasif aktif yapabilir.events dan da ayarlanabilir ama biz kodla yazdık.false ayarlayıp pasif yapmak istiyoruz nesnelerimizi.
            btnmesajver.Visible = false; // mesaj ver butonunu visible yaptık because biz izin ver dediğimizde görünmesini istiyoruz , izin ver dediğimizde ust satırda pasif ayarladıklarımızda aktif olacak alt satırlarda yazacagız zaten devam
            tutarkaplanrengi = tbnumara.BackColor; //tbnumara renk değişimi için yardımcı olacaklar bu iki satırdaki degiskenleri class ta tanımlamıstık acıklamasını oku 
            tutyazırengi = tbnumara.ForeColor;
        }

        private void btnizinver_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("izin verilsin mi ?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // biz izinver isimli butondan mesaj verilmesini istiyoruz,bunun için messagebox kullandık. mesagebox ın dialogresult türünden tanımlandıgını unutmayalım, cevap isimli bir değişken ayarladık türünü mesageboxla aynı yapmalıyız ve verilen mesajın soru olmasını ve cevabı kaydetmesını istiyoruz bu cevabı atamak için degişken tanımladık.mesagebox ın 7.kullanımından yararlandık,4 parametreden olusuyor mesaj,baslık,bize sunacagı butonlar (cevabı degıskene aktardıgımız),ve mesajın sembolu seklınde.
            if(cevap == DialogResult.Yes)
            {
                tbnumara.Enabled = tbadsoyad.Enabled = true;
                btnmesajver.Visible = true;
                tbnumara.Focus(); // textboxnumaraya eger cevap yes ise focus oluyor,imleci orda baslıyor yes dedikten sonra.
            }
        }
        void renklendir(TextBox hangisi) // fonksiyon olusturduk renklendir isimli,textbox türünden de bir hangisi isimli parametre olusturduk.yani ben buraya hangi textboxu gönderirsem onu renklendirsin istiyorum kodu asagıdaki gibi .aslında bunu asagıda yaptıgımız renklendirmelerin daha kolay hali daha pratik hali için yapıyoruz
        {
           hangisi.BackColor = Color.Pink; // hangisi yani hangi parametreyi gönderirsek onun rengiyle oynuyoruz.nesneye y.p da fonksiyona sadece bir degişken degil nesneleri de parametre olarak gönderebiliriz.simdi renk degistirmek istersek sadece buradan degişsek yeterli ilk yöntemde birden fazla yerden degişmek gerekiyordu
           hangisi.ForeColor = Color.Purple;
        }
        void eski_haline_getir(TextBox hangisi)
        {
            hangisi.BackColor = tutarkaplanrengi; // aynı seyi leave için de yaptık 
            hangisi.ForeColor = tutyazırengi;
        }
        private void tbnumara_Enter(object sender, EventArgs e) // tbnumara nesnesine giriş,mausla geldiğimiz zaman değişiklik olsun istemiyoruz.nesnenin içine girildiği zaman değişiklik olsun istiyoruz,yani imlec o kutudayken.
        {
          //  tbnumara.BackColor = Color.Pink; // fonk atamadan önce bunları kullanmıstık ilk yöntem yani simdi fomk kullandıgımız için acıklama seklıne getirdik ilk halini de görebilmek için bırsktık burda
          //  tbnumara.ForeColor = Color.Purple;
            renklendir(tbnumara);
        }

        private void tbnumara_Leave(object sender, EventArgs e)
        {
           // tbnumara.BackColor = tutarkaplanrengi;
           //tbnumara.ForeColor = tutyazırengi;
            eski_haline_getir(tbnumara);
        }

        private void tbadsoyad_Enter(object sender, EventArgs e) // tbnumara renk işlemini tbadsoyad için de yapıyoruz.
        {
            //tbadsoyad.BackColor = Color.Pink;
            //tbadsoyad.ForeColor = Color.Purple;
            renklendir(tbadsoyad); // tbadsoyada girildiginde renklendir fonk nunu cagıracak ve orda hangisi adlı nesne bunu karsılayacak 
        }

        private void tbadsoyad_Leave(object sender, EventArgs e)
        {
           // tbadsoyad.BackColor = tutarkaplanrengi;
           // tbadsoyad.ForeColor = tutyazırengi;
            eski_haline_getir(tbadsoyad);
        }

        private void btnmesajver_Click(object sender, EventArgs e)
        {
            string cinsiyet = null; // cinsiyet degişkenine secilen cinsiyet atanacak ve bunu mesaj verme kodunda kullanacagız. null demek baslarken bos kalmasın diye bi terim sıfır gibi bişey atadık
            if (rberkek.Checked) cinsiyet = rberkek.Text; // eger erkek secıldıyse textını cınsıyete aktardık 
            if (rbkadin.Checked) cinsiyet = rbkadin.Text; // if(...) yapmak yerine sadece else de yazabılırdık ama bunu tercıh ettık
            MessageBox.Show("Numara: " + tbnumara.Text + "\nAdı ve Soaydı: " + tbadsoyad.Text + "\nCinsiyet: " + cinsiyet + "\nyaş: " + nuyas.Value); // \n new lıne idi asagı satırdan baslamak için baslarına yazdık. ve nuyas isimli nesne dede text özelliği yerine value kullandık cunku strıng degıl sayı ataması yapılacak oraya.
            tbnumara.Enabled = tbadsoyad.Enabled = btnmesajver.Visible = false; // enabled ile pasif ve visible ile gorunmez yaptık cunku mesaj penceresi kapandıgında en bastaki haline gelmesini istiyoruz basta da bunlar false idi

        }

        private void btnrenkdegistir_Click(object sender, EventArgs e)
        {
            DialogResult cevap = colorDialog1.ShowDialog(); // colordialog nesnesini acıp renk tablosunu gösteren kod bu. dialogresult turunden cevap adlı degıskene ok mu yoksa ıptal mı bastık o renk tablosunda renk sectıkten sonra bunu degıskene aktardık.
            if (cevap == DialogResult.OK) // eger cevap ok ise
            {
                if (rbarkaplanrengi.Checked) this.BackColor = colorDialog1.Color; // eger arkaplan rengi butonu secılıyse secılen renk back colora aktarılır. this forma yazıgımız için nesneye yazsak nesne ismi kullanıyoruz forma ise this kullanıyoruz
                else if (rbyazirengi.Checked) this.ForeColor = colorDialog1.Color;
                else MessageBox.Show("Lütfen rengin uygulanacağı radıobutonu seçin"); // eger hıcbı buton secılmedıyse diye mesaj verdirdik
               
                    
            }
            /*   yada şöyle yapabiliriz ; (boyle yazıldıgında eger buton secmedoysen once uyarı mesajı gelıyor bizim yazdıgımızda renk ekranı acılıyor ve secılmedıyse sonra mesaj gelıyor)
                if (!rbyazirengi.Checked && !rbarkaplanrengi.Checked) messagebox.show("LUTFEN RENGIN UYG BUTONU SEC "); // eger (yazı rengı ve arkap rengı secılı degılse) yap
               else 
               {  DialogResult cevap = colorDialog1.ShowDialog();
                   if (rbarkaplanrengi.Checked) this.BackColor = colorDialog1.Color;
                   else this.ForeColor = colorDialog1.Color;
               }
            */

        }
    }
}
