using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace _26_mayıs
{
    public partial class Form1 : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        int kacincikayıt;
        bool yenikayitmi;



        public Form1()
        {
            InitializeComponent();
        }

        void verileri_cek() 
        {
            string sec = "select a.*,b.bolumad from anablmdalı as a, bolumler as b where a.bkodu=b.bolumkodu"; // sec a tablosunun *(tum) fıeldlarını,b tablosundan bolumad fıeldını.fromdan sonrakı kısım : a anablmdalı nı b bolumler i temsil ediyor.where komuttu a daki bkodu ve b deki bolumkodu eşleşiyorsa yap bastaki komutu. eger wherede yazılı şartı koymasaydık bolumler tableından bolumad fıeldındakı tum kayıtları getırırdı ancak sımdı anablndalında kodu yazılı olan bolumadını getırecek.
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);
            if (ds.Tables["anablmdalı"] != null) ds.Tables["anablmdalı"].Clear();
            da.Fill(ds, "anablmdalı");  
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            badi.Enabled = abdadi.Enabled = abdkodu.Enabled = false;     
            btnkaydet.Visible = btniptal.Visible = false;         
            btngeri.Enabled = false;

            if (conn.State == ConnectionState.Closed) conn.Open();

            verileri_cek();
            //dataGridView1.DataSource = ds.Tables["anablmdalı"];

            bs.DataSource = ds.Tables["anablmdalı"];         // bs nin data kaynağı datasetin anablmdalı table ı oldu
            dataGridView1.DataSource = bs;                   // datagridviewin kaynagı da bs ile aynı oldu
            abdkodu.DataBindings.Add("Text", bs, "abdkodu");  // abdkodu adlı text boxın  (text özelliğini bsnin abdkodu adlı fıeldına) bağla
            abdadi.DataBindings.Add("Text", bs, "abdadi");     
            badi.DataBindings.Add("SelectedValue", bs, "bkodu");  //badi adlı combobox ın selectedvalue ozellıgıne bs nin bkodu fıeldını aktar



            string sec = "select * from bolumler";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, conn);  // 3.parametre(strıng selectcommantext , oledbconnectıon selectconnectıon) sql cumlecıgı,connectıon nesnesi . datadapter veriyi üxerinde barındıramaz sadece veriyi cekmekle sorumlu.dataadapter in fill metoduyla veriyi datasette barındırabiliriz
            // Oledbdataadapter nesnesi olustur,bu nesnede sec string degiskeninin icindeki sql cumlecigini calistir,ve bunu calistirirken de veritabanina conn connection nesnesi vasitasiyla baglan
            da.Fill(ds, "bolumler"); da.Fill(ds, "bolumler1"); // 3.parametre(dataset nesnesi,strıng src table).datasette birden fazla table saklayabiliriz iki table a ıhtıyacımız var bu programda ıkı farklı kaynak ıcın.cunku comboboxların kaynagını asagıda belirlerken 1 table kullanırsak bir comboda secılen ders dıgerındede gozukuyor kaynak aynı oldugu ıcın.secımı o table da yapıyor aslında.ıkı table olursa ıkısını farklı baglarsak secımlerı farklı tablelardan yaparız.fiziksel dosyada tablelar aynı bunlar sanal dosya bolumler1 desekte fark etmez.aslında arka planda aynı table 

            badi.DataSource = ds.Tables["bolumler"];
            badi.DisplayMember = "bolumad";   // tablodaki bolumad fıeldını comboboxta goruntulencek kısma aktarıyoruz
            badi.ValueMember = "bolumkodu";   // bolumkodu fıeldını ıse combobox ın arka kısmında saklayacagız value(deger) kısmında.kullanıcının gormedıgı kısım.

            badiara.DataSource = ds.Tables["bolumler1"];
            badiara.DisplayMember = "bolumad";   
            badiara.ValueMember = "bolumkodu"; 


        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            badi.Enabled = abdadi.Enabled = true;
            abdadi.Clear();
            abdadi.Focus();
            btnkaydet.Visible = btniptal.Visible = true;
            kacincikayıt = ds.Tables["anablmdalı"].Rows.Count; // kayıt sayısını aldık.yani son kayıt
            yenikayitmi = true;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();   // veritabanına kayıt yaparken command nesnesi kullanıyoruz.
            cmd.Connection = conn;               //------confıguratıon yapılıyor           
            if (yenikayitmi)
            {
                cmd.CommandText = "insert into anablmdalı (abdadi,bkodu) values(@abdadi,@bkodu)";   
                cmd.Parameters.AddWithValue("@abdadi",abdadi.Text);
                cmd.Parameters.AddWithValue("@bkodu", badi.SelectedValue);
               //--------------------------------------------------------------
            }
            else
            {
               // cmd.CommandText = "update bolumler set bolumad=@bolumad where bolumkodu=@bolumkodu";  
                //cmd.Parameters.AddWithValue("@bolumad", tbbolumadi.Text);
                //cmd.Parameters.AddWithValue("@bolumkodu", tbbolumkodu.Text);

            }

            cmd.ExecuteNonQuery();    // run eder
            MessageBox.Show("işlem  gerçekleştirildi");
            verileri_cek(); // dataseti veri girdikten sonra güncellemiş oluyoruz
            bs.Position = kacincikayıt;

            abdadi.Enabled = badi.Enabled = false;
            btnkaydet.Visible = btniptal.Visible = false;
        }

      
    }
}
