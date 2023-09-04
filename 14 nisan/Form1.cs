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
    public partial class Form1 : Form
    {
        bool[] koltuklar; // bool türünde koltuklar dizisi global olmasını istedik 
        public Form1()
        {
            InitializeComponent();
        }

        private void buton_islem(object sender, EventArgs e) // senderın görevi en son tıklanan nesneyi tutmaktır.butonsa o butonu tutar. bu buton_ıslem fonk cagrıldıgında etkılesır
        {
            Button btn = (Button)sender; // gelen sender nesnesini butona cevırıp btn nesnesine aktardık.burda btn nesnesi koltukların butonlarını temsil ediyor
            // sender tıklanan butonu tutuyo ama obje olarak.daha sonra o tutulanı btn denen buton haline aktarıyoruz.butonu hatırlayan sey sender komutu.buton türünden tanımlanan btn sanırım bi arac oluyor.
            if (koltuklar [int.Parse(btn.Name)]==true) // eger koltuk secılı ıse (true ıse) butona basıldıgında yapılacaklar
            {
                btn.BackColor = Color.White;
                koltuklar[int.Parse(btn.Name)] = false;
            }
            else // koltuk secılı degılse butona tıklandıgında yapılacaklar
            {
                btn.BackColor = Color.Pink;
                koltuklar[int.Parse(btn.Name)] = true;
            }
            label2.Text = "";
            for (int i = 0; i < int.Parse(tbadet.Text); i++)
                if (koltuklar[i] == true) label2.Text += "koltuk-" + (i + 1).ToString() +"  ";

        }
        
    
          private void btnekle_Click(object sender, EventArgs e)
        {
              try // ekle butonuna bos basıldıgında hata verdıgı ıcın catch kısmında mesaj kodu yazdık
              {
            koltuklar = new bool[int.Parse(tbadet.Text)]; // textbox a girilen(tbadet) sayı kadar dizi olusturduk
            int kactane = 0; int ust = 70;
            for (int i=0;i<int.Parse(tbadet.Text);i++) // textboxa yazdıgımız sayı kadar donuyor.cunku her dongu dondugunde bir b adlı buton eklenıyor konumlanıyor isimleniyor rengi ayarlanıyor.kısaca for dongusu ıcıne yazdıgımız kodlar gerceklesıyor
            {
               
                    Button b = new Button(); // ismi b olan buton türünden nesne tanımladık
                    b.Name = i.ToString(); // b butonunun ismini degıstık.ındexıyle ismi eszamanlı gidebilir halde bu sayede.
                    b.Text = "koltuk " + (i + 1).ToString(); // b butonu textını degıstık
                    b.BackColor = Color.White; // b butonu arkaplan rengını sectık

                    if (i % 5 == 0) // i nin 5 e bolumunden kalan sıfır ise yap asagıdakı suslu parantez ıcındekını
                    { ust += 25; kactane = 0; } // ust u 25 artır kı 5 tane de bir alta gecsın eger 6 ise 1 buton altta konumlanıyor.ve kactane degerını sıfır yaptık ki alt satıra gecınce en bastan konumlansın

                    kactane++; // 0 ayarlanmıstı 1 artırıp asagıdan 60 ıle carpıyoruz sonra 60 brm ilk buton sola kayıyor(left ile) sonra basa donuldugunde 1 daha artıyor 2 oluyor 2.buton 60x2 den 120 brm sol konumlanıyor.
                    b.Left = kactane * 60; // ilk buton 80 brm solda ikincisi 2x80 olcagı ıcın 160 brm solda oluyor bunu yapmasak 5 buton ekledıysek 5 ı de ustuste gelıyodu.
                    b.Top = ust; // ust u 85 tanımladık 85 brm ustten olcak sekılde(top) konumu ayarlandı
                    b.Click += new EventHandler(buton_islem); // b nesnesının clıclk ozellıgı etkınlestıgınde buton_ıslem adlı fonk gerceklessın ıstıyoruz.böylece b nesnesınden 10 tane ekledıysek 10 unda da tek bi kodla degısıklık yapabılırız..eventhandlertipinde tanımladık cok takılma
                    Controls.Add(b); // b butonunu ekledik
                }
                  
            }
              catch (FormatException) { MessageBox.Show("adet giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); } 
           

        }

          private void btnucrethesapla_Click(object sender, EventArgs e)
          {
              int kackoltuksecili = 0;
              for (int i = 0; i < int.Parse(tbadet.Text); i++) // bu for dçögüsünde yapılmak istenen şey secili koltuk sayısını tespit etmek 2 asagıdakı satırda kullanacagız
                  if (koltuklar[i]) kackoltuksecili++;
              try
              {
                  label4.Text = (int.Parse(tbbirimucret.Text) * kackoltuksecili).ToString(); // birim ucretı klavyeden giriliyor.secılen koltuk sayısını kackoltuksecılı adlı bellekte tutmustuk ucretı onunla carpıp labela aktarma kodu yazdık.secılen koltukların parasını hesaplayan sıstemı kurmus olduk
              }
              catch { MessageBox.Show("belirlediğiniz birim ücreti giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
          }

    }
}
