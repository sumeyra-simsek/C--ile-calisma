using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // oledb nesnesını kullanacagımız ıcın boyle yazıyoruz !!!

// ödev contextmenudeki komutları butonlara baglıcaz.ve eklenen toolstrıplabel bize kac kayıt oldugunu kacıncıda oldugunuda sanırım gostersın. 1/3 gibi.
namespace _21_nisan
{
    public partial class Form1 : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb"); //oledbconnectıon sayesınde veritabanına baglanıyoruz. parantez içini ıntten copy paste ettık Application.StartupPath uygulamanın basladıgı klasor demek.burda yani veritabanı kaynagını conn olarak aktardık sanırım.conn open dendgınde bu kod sayesınde verıtabanına baglanıyor.ayrıca not : parantez ıcınde provıderı dogru vermek , path i dogru vermek ve veritabanı ismini dogru yazmaya dıkkat edılmelı
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource(); // baglantı kaynagı tanımladık 

        int kacincikayıt;
        bool yenikayitmi;


        public Form1()
        {
            InitializeComponent();
        }



        void verileri_cek() // burda yzılan kodlar tekrar eden kodlar.lazım olan yerlerde bu fonksıyonu cagıracagız.
        {
            string sec = "select * from bolumler ";                // bolmler tablosundakı butun fıeldları sec dedık * fıeld oluyor burda.ve bu secılenlerı sec dıye bır degıskene atadık.eger * yerıne bkodu deseydık bolumler table ından bkodu nu alırdı .bkodu,badi deseydık * ın yaptıgı gorevı yapardı zatem bu ıkı fıeld var bolumler table ında totelde.
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn); // adapter vasıtasıyla select cumlecıgını uyguluyoruz.ust satırda selectı kullanarak verılerı sece aktardık sımdı adapter yardımıyla conndan bu verılerı alıyoruz (conn burda veritabanı temsıl edıyor sanırım)
            if (ds.Tables["bolumler"] != null) ds.Tables["bolumler"].Clear(); // bolumler table ı varsa(null degılse) temizle dedik cunku alt satırlarda kaydet btn una basılsıgında temızlemeden yeni ders ekliyordu  oncekı kayıtlarla beraber .sorunu boyle cozduk.ıf koymadıgımız zaman sadece clear dedıgımızde de loadda sorun cıkıyordu henuz olusmamıs bı tableı temızle dedıgımız ıcın(alt satırda olusuyor).onun arkasından yazsaydık yıne sorun cıkardı tum tabloyu temızlemıs olurduk buda ısımıze yaramazdı.
            da.Fill(ds, "bolumler");                               // dataadpterden cekmıs oldugumuz kayıtları/verileri doldurduk datasete (ram bellege) fill : doldurmak. yani bu satırda table olustu.evet biz acceste yaptık ama buraya bu kodlarla getırdık ve doldurduk.accestekıler fızıksel verı burda datasette saklananlar sanalveriler. 
            // yani bu fonksıyon kısacası bolumler table ını olusturup fıeldlarını cagıran ve ram bellekte ıhtıyac olunca formda kullanmak için saklayan kodların bulundugu fonksıyon.                                             
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            tbbolumadi.ReadOnly = tbbolumkodu.ReadOnly = true;     // sadece okunabilir olsun dedik.yani yazı yazılmıyor tblara sadece okunuyor
            btnkaydet.Visible = btniptal.Visible = false;          // visible ı false yapmak gorunmemesi demek.
            btngeri.Enabled = false;

            if (conn.State == ConnectionState.Closed) conn.Open();   // eger conn dosyası durumu kapalıysa yap cunku eger acıksa ve acmaya calısırsak hata verir. // state : durum

            verileri_cek();    //fonk cagırdık onceden burda olan kodlar o fonksıyonda yazılı.acıklamalarla beraber taşıdım kodları o fonksıyona.
                                                              
            bs.DataSource = ds.Tables["bolumler"];  // bındıngsource yani baglantıkaynagı bs demıstık.bs veri kaynagını bolumler table ından alsın dedik
            dataGridView1.DataSource = bs;          //datagrıd kaynagını bındıngsource(bs)den alsın dedik.o da bolumler table ından alıyor
                                                    // source : kaynak
            tbbolumkodu.DataBindings.Add("Text", bs, "bolumkodu");  // ikinci parametreye gore parantez ıcını yazdık.(property(ozellık),datasource(kaynak),datamember(fıeld yani))
            tbbolumadi.DataBindings.Add("Text", bs, "bolumad");     // bolum adı text boxına bır verı baglantısı (databındıngs) ekle (add) dıyoruz.text ozellıgıne ekleyecek("text" , bs ,"badi") bs nesnesinin badi fıeldından alacak
        }



        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            tbbolumadi.ReadOnly = false;
            tbbolumadi.Clear(); tbbolumkodu.Clear();
            tbbolumadi.Focus();
            btnkaydet.Visible = btniptal.Visible = true;
            kacincikayıt = ds.Tables["bolumler"].Rows.Count; // kayıt sayısını aldık.yani son kayıt
            yenikayitmi = true;

        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;                            //----------------------- confıguratıon yapılıyor (yapılandırma , biçimlendirme ) yani bunlar calısan eyleme gecen kodlar degıl ayarlama,yapılanma kodları 
            if (yenikayitmi)
            {
                cmd.CommandText = "insert into bolumler (bolumad) values(@bolumad)";    // commandtext yani komut cumlesı .hangi sql cumlecıgı ıle ıslemı yapacaksak bunu commandtext ile kullanıyoruz.veritabanına kayıt ıcın ınsert kullanılır.ınto (içine , dogru.yonelme) gibi .bolumler tableına.bolumlerin (bolumad)alanına ekle.bolumad degeri(value) @bolumad(parametre) dan alacak .  yani "sql cumlecıgı + into + içine veri aktarmak ıstedıgımız table + (fıeldın adı) + value + @fıeldınadı "
                cmd.Parameters.AddWithValue("@bolumad", tbbolumadi.Text);               // @bolumad parametresini tanımladık. @bolumad parametresi veriyi bolumadı text box ından alsın diyoruz. yani veri textboxtan @bolumad parametresine ordanda bolumler tableının bolumad fıeldına kayıt olarak ekleniyor
                //-------------------------------------------------------------------------buraya kadar cnfıgurtıon yapılıor
            }
            else
            {
                cmd.CommandText = "update bolumler set bolumad=@bolumad where bolumkodu=@bolumkodu";    // sql in if komutu where dir.
                cmd.Parameters.AddWithValue("@bolumad", tbbolumadi.Text);
                cmd.Parameters.AddWithValue("@bolumkodu", tbbolumkodu.Text);

            }

            cmd.ExecuteNonQuery();           //run eder(yürütme). yani yukarda confıgure olan kodlar burda calısıyor.
            MessageBox.Show("işlem  gerçekleştirildi");
            verileri_cek();
            bs.Position = kacincikayıt;      // bs ye bolumler table ını aktarmıstık loadda. bunun pozisyonunu kacincikayıt olarak degısınce secılı olan bolum en sondaki yani kacincikayıtta belırlenen satır oluyor

            tbbolumadi.ReadOnly = true;
            btnkaydet.Visible = btniptal.Visible = false;
        }



        private void btniptal_Click(object sender, EventArgs e)
        {
            tbbolumadi.ReadOnly = true;
            btnkaydet.Visible = btniptal.Visible = false;
        }



        private void btnileri_Click(object sender, EventArgs e)
        {
            if (++bs.Position == ds.Tables["bolumler"].Rows.Count - 1) btnileri.Enabled = false; btngeri.Enabled = true;
        }



        private void btngeri_Click(object sender, EventArgs e)
        {
            if (--bs.Position <= 0) btngeri.Enabled = false; btnileri.Enabled = true;
      
        }



        private void btnduzelt_Click(object sender, EventArgs e)
        {
            tbbolumadi.ReadOnly = false;
            tbbolumadi.Focus();
            btnkaydet.Visible = btniptal.Visible = true;
            kacincikayıt = bs.Position;
            yenikayitmi = false; // btnkaydet clıck kısmında else ıle duzeltme devreye gırıyor.yenikayitmi degıskenı sayesınde
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            kacincikayıt = bs.Position;
            DialogResult cevap = MessageBox.Show("silmek ister misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cevap==DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from bolumler where bolumkodu=@bolumkodu "; // komut textı
                cmd.Parameters.AddWithValue("@bolumkodu", tbbolumkodu.Text);          // parametre 
                cmd.ExecuteNonQuery();
                MessageBox.Show("kaydınız silindi");
                verileri_cek();
                bs.Position = kacincikayıt;

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void tbaranan_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from bolumler where bolumad like'%"+tbaranan.Text+"%'"; // select * from bolumler where bolumad='bilgisayar'. % isareti %müh% ise yazdıgımız muhendıslerı cıkarır dıgerlerını eleyıp. ıcınde müh yazanları getırıyor
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            if (ds.Tables["bolumler"] != null) ds.Tables["bolumler"].Clear();
            da.Fill(ds, "bolumler");
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btnsil_Click(sender, e);
        }
    }
}
