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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Dersler.Items.Add("makıne ögrenmesı");
            Dersler.Items.Add("matematık");
            tbYenıders.Visible = false;
            progressBar1.Maximum = Dersler.Items.Count;
            if (Dersler.Items.Count == 0) btnekle.Enabled = false; // count = miktar demek
            if (secilendersler.Items.Count == 0) btncıkar.Enabled = false;
            if (Dersler.Items.Count > 0) Dersler.SelectedIndex = 0; // baslarken 0.ındex yanı en bastakı ders secılı gelsın ekleye basınca dırekt aktaralım ıstıyoruz bunu ekledıkten sonrakılerının secılı gelmesı ıcın btnekle clıck e kod yazıyoruz
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (Dersler.SelectedIndex < 0) MessageBox.Show("lutfen ders secınız"); // burd ıf else yapma nedenımız hata vermesı baslarken. bısey secmeden ekleye basınca hata verdı bızde hatayı onlemek ıcın mesaj koyduk.
            else
            {
                secilendersler.Items.Add(Dersler.SelectedItem); // secılenderslerın ıtemlerıne ekle (derslerın secılı ıtemını)
                // Dersler.Items.Remove(Dersler.SelectedItem); // derslerın ıtemlerınden kaldır (derslerden secılı ıtemı ) ( remove = kaldır)
                Dersler.Items.RemoveAt(Dersler.SelectedIndex); // bu sekılde de yazılabılır remove at kullanmak ındexıne gore sılmek demektır . remove dırekt secılı olanı arayıp sılıyor secılı olan matematıkse matematıgı secer ama removeat (matematık bastan 4. yanı ındex 3,sıfırdan saymaya baslarız) 3.sıradakını siliyor . eger herhangı bırı secılı degılse ındex -1 dir.
                btncıkar.Enabled = true;
                if (Dersler.Items.Count == 0) btnekle.Enabled = false; // tum derslerı ekledık ve dersler kısmı bos kaldı yıne ekleye basıyoruz ve ders secın mesajı verıyor ama sececek ders yok mantık hatası oluyor. bu yuzden dedıkkı : eger (derslerdekı ıtem mıktarı sıfır ıse) btn ekleyı gızle dedık.
                progressBar1.Value++; // butona her bastıgımızda bar 1 ılerlıyor
                if (Dersler.Items.Count > 0) Dersler.SelectedIndex = 0;
            }
        }

        private void btncıkar_Click(object sender, EventArgs e)
        {
            if (secilendersler.SelectedIndex < 0) MessageBox.Show("lutfen ders secınız");
            else 
            {
                Dersler.Items.Add(secilendersler.SelectedItem);
                secilendersler.Items.Remove(secilendersler.SelectedItem);
                btnekle.Enabled = true;
                if (secilendersler.Items.Count == 0) btncıkar.Enabled = false;
                progressBar1.Value--;
                if (secilendersler.Items.Count > 0) secilendersler.SelectedIndex = 0;
            }
            // dersler lıstboxuna cıft tıklandıgında ekle butonu calıssın ıstıyoruz o yuzden propertıes eventsdan double clıck ten btnekle yı sectık. sımdı derslere cıft tık yapıldıgında secılem ders kısmına o ders gecıyorr
            // aynı seyı secılemdersler lıstboxun ın double clıck ıne yaptık oraya da btncıkarı bagladık cıft tıklandıgında secılenı cıkarıp dersler lıstboxuna aktarıyır

        }

        private void cbyeniders_Click(object sender, EventArgs e)
        {
            if (cbyeniders.Checked) tbYenıders.Visible = true;
            else tbYenıders.Visible = false;
        }

        private void tbYenıders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter) // e parametresi textbox ın calısması ıcın basılacak tuşun kodunu verıyor mus
            {
                if (tbYenıders.Text ==  "") MessageBox.Show("lutfen ders giriniz"); // bısey yazmadan enter dersek mesaj gelıyor 
                else
                {
                    Dersler.Items.Add(tbYenıders.Text); // texte yazılanı aktar
                    progressBar1.Maximum++; // 1 arttırdık barın max ını yenı ders gırdgımız ıcın
                    tbYenıders.Text = ""; // yazdıgımız ders eklendıkten sonra silinsin textboxta kalmasın diye bosluk aktardık
                    MessageBox.Show("Dersler eklendı"); //ders eklendıgınde mesaj versın
                }
            }
        }

        private void btncokluders_Click(object sender, EventArgs e)
        {
            try
            {


                byte kactane = byte.Parse(Interaction.InputBox("kaç ders gireceksiniz?")); // sayı gırıyoruz ve bunu kactane adlı degıskene aktarıyor.sayı gırdıgımız ıcın ınt tanımladık .ınt.ınputbox ı mıcrosoftvısualbasıc kutuphanesınden aldık. solıtondan hafta2 references dan add reference yap ekle. sonra da en basta usıng duye tanımla.ınt parse yaptık vunku ınt.ınputbox her zmn strıng deger dondurur
                for (int i = 1; i <= kactane; i++) // gırdıgımız deger 1 den buyuk yada esıt olmalı
                {
                    string eklenen = Interaction.InputBox(i + ". dersi giriniz"); // 1.dersi giriniz kutusuna yazılanı aktarıyor eklenen degıskenıne. strıng cunku harf gırıyoruz cıkan kutuya onu strıng degıskene aktarmalıyız
                    Dersler.Items.Add(eklenen); // eklenene aktarılan kullanıcının yazdıgı dersı lısteboxa gırıyor
                    progressBar1.Maximum++; // barı 1 arttırıyor ders gırıldıgı ıcın
                }

            }
            catch (FormatException) { MessageBox.Show("lutfen rakam girin"); } // formatexceptıon rakam gırılmesı gereken yerde harf gırılırse dıye kullamdık. ve bır mesaj verdık  try catch ıle yaptık 
            catch (OverflowException) { MessageBox.Show("negatıf sayı gırdınız"); }

        }

        private void secımıIptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersler.SelectedIndex = -1;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("cıkmak ıstıyır musunuz", "bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes) Application.Exit();
        }

       
    }
}
