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
    public partial class Form3 : Form
    {
        public static string adsoyad; // statıc dedıgımızde form2 de form3.adsoyad dıyebılırız .dıger formlardan bu forma erısebılmek kullanabılmek ıcın statıc dıyoruz.form 3 tekı bu adsoyad degıskenını form2den kullanacagız
        public Form3()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("users.xml");
            bool kontrol = false;
            for (int i = 0; i< ds.Tables[0].Rows.Count; i++)
            {
                if (tbka.Text == ds.Tables[0].Rows[i]["ka"].ToString() && // && yazınca eger ilk sart dogruysa ıkıncıye bakıyordu
                    tbsf.Text == ds.Tables[0].Rows[i]["sf"].ToString() )
                {
                    adsoyad = ds.Tables[0].Rows[i]["adi"].ToString() + " " + ds.Tables[0].Rows[i]["soyad"].ToString();
                    kontrol = true;
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
            }

            if (kontrol == false)

                MessageBox.Show("yanlış kullanıcı adı veya şifre");

        }
    }
}
