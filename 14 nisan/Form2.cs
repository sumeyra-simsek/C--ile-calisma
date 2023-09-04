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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // not : xml dosyası eklemeyi telefona not aldım. sil ve duzelt islemleri ödev bide aynı ka ve sf eklenmesını engelle bu da ödev.duzelt dedıgı sey lıstede ısmı olan bırının ka ve sf degıstırmek ıstıyoruz yazıyoryz duzelt dıyoruz ve duzelıyo bunu yap .love yourself kuzum hadi bye
        DataSet ds = new DataSet(); 

        private void Form2_Load(object sender, EventArgs e)
        {
            btntamam.Enabled = btnıptal.Enabled = false;
            ds.ReadXml("users.xml"); // users.xml dosyasını data okur ve kendi icindeki table a aktarır . bi tane dosya okudgu ıcın bu sıfırncı table dır.bu arka planda ram bellekte gerceklestı bu kodla beraber
            dataGridView1.DataSource = ds.Tables[0]; // data grıd data kaynagını (data source) sıfırıncı table dan alsın dedik.böylece datagrıd nesnesıne users.xml bilgileri yerlesmıs oldu.

            label5.Text = Form3.adsoyad; // label5 sol en ust koseye koydugumuz label form 2 ıle form 3 u bagladık programcs den form3 u etkınlestırıp cıkan form3 ekranına k.a ve sıfre yazdıgımızda form 2 acılıyor ve label5 ın yerınde o kısının adı cıkıyor.adsoyas form3den aldıgımız bır degısken
        }

        private void btnyenı_Click(object sender, EventArgs e)
        {
            btntamam.Enabled = btnıptal.Enabled = true;
            tbad.Clear(); tbka.Clear(); tbsf.Clear(); tbsoyad.Clear();
            tbka.Focus();
        }

        private void btntamam_Click(object sender, EventArgs e)
        {
            btntamam.Enabled = btnıptal.Enabled = false;
            DataRow dr = ds.Tables[0].NewRow(); // dr isimli datarow ekledik ve bbu datarow ds table ına uygun bi datarow olsun.yani aslında isimlerin vs yazılı old mevcut table da yeni bir satır(row) olusturuyoruz bu kodla 
            dr["adi"] = tbad.Text;
            dr["soyad"] = tbsoyad.Text;
            dr["ka"] = tbka.Text;
            dr["sf"] = tbsf.Text;

            ds.Tables[0].Rows.Add(dr); // eklenen satır bellekteki sanal dosyaya eklenir
            ds.WriteXml("users.xml"); //eklenen satır bellekteki fiziksel dosyaya eklenir.eklenen yeni satır form kapatıp acılınca kayboluyordu user.xml(kaynak dosya) de bulunmadıgı ıcın oraya da aktarmıs olduk.
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) // datagrıddekı secılı kayıt degıstıgı zaman olacak ıslem ıcın selectıonchanged eventsını kullanıyoruz
        {
            try
            {
                int kayitno = dataGridView1.CurrentRow.Index; // currentrow gecerlı satır anlamına gelır.datagrıdde secılı satırın ındexını kayitno adlı yere aktardık
                tbad.Text = ds.Tables[0].Rows[kayitno]["adi"].ToString(); // tbad isimli textboxın textıne sıfır ındexlı table dan secılı(ust satırda secılı satırı kayıtno ya aktardık)  satırın adi kısmını aktarıyoruz.try catch e aldık cunku aynı anda hem table olusturup hem burayı yapınca acılırken hata verıyor
                tbsoyad.Text = ds.Tables[0].Rows[kayitno]["soyad"].ToString();
                tbsf.Text = ds.Tables[0].Rows[kayitno]["sf"].ToString();
                tbka.Text = ds.Tables[0].Rows[kayitno]["ka"].ToString();
            }
            catch { }
        }

        private void btnıptal_Click(object sender, EventArgs e)
        {
            btntamam.Enabled = btnıptal.Enabled = false;
        }
    }
}
