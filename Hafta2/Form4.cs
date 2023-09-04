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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void goster(RadioButton hangisi, Label nereye)
    {
        nereye.Text = "seçilen: " +hangisi.Text; // labela aktar rb nin textini fonk olarak yazdık cunku diğer turlu ayrı ayrı yazdıgımızda bısey degıstırmek ıstendıgınde her yerden degısırdık tek bıyerde toplamıs oluyoruz
    }

        private void rbevli_CheckedChanged(object sender, EventArgs e)
        {
           // label1.Text = rbevli.Text;
            goster(rbevli, label1);
        }

        private void rbbekar_CheckedChanged(object sender, EventArgs e)
        {
            //label1.Text = rbbekar.Text;
            goster(rbbekar, label1);
        }

        private void rbdul_CheckedChanged(object sender, EventArgs e)
        {
            //label1.Text = rbdul.Text;
            goster(rbdul, label1);
        }

        private void rbortaokul_CheckedChanged(object sender, EventArgs e)
        {
            //label2.Text = rbortaokul.Text;
            goster(rbortaokul, label2);
        }

        private void rblise_CheckedChanged(object sender, EventArgs e)
        {
            goster(rblise, label2);
        }

        private void rblisans_CheckedChanged(object sender, EventArgs e)
        {
            goster(rblisans, label2);
        }

        private void rblisansustu_CheckedChanged(object sender, EventArgs e)
        {
            goster(rblisansustu, label2);
        }

        void ekle (CheckBox hangisi)
        {
            
             if (hangisi.Checked) listBox1.Items.Add(hangisi.Text);
             
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
           /* if (cbfutbol.Checked) listBox1.Items.Add(cbfutbol.Text);
            if (cbgezi.Checked) listBox1.Items.Add(cbgezi.Text); 
            if (cbkitap.Checked) listBox1.Items.Add(cbkitap.Text);
            if (cbyüzme.Checked) listBox1.Items.Add(cbyüzme.Text); 
             ilk basta boyle yazdık sonra fonksıyon yapmaya karar verdık   */
            ekle(cbyüzme); ekle(cbkitap); ekle(cbgezi); ekle(cbfutbol);
            

        }
        
        void cıkar (CheckBox hangisi)
        {
            if (listBox1.SelectedItem.ToString() == hangisi.Text) hangisi.Checked = false; // tekrar eden kod oldugu ıcın fonk halıne getırıyoruz tekrar etmeyen faktoru de degısken halıne getırıyoruz
        }

        private void btncıkar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
              /*  if (listBox1.SelectedItem.ToString() == cbfutbol.Text) cbfutbol.Checked = false; // cıkarırken chechboxtakı ısaretı de kaldırıyoruz
                if (listBox1.SelectedItem.ToString() == cbyüzme.Text) cbyüzme.Checked = false;
                if (listBox1.SelectedItem.ToString() == cbkitap.Text) cbkitap.Checked = false;
                if (listBox1.SelectedItem.ToString() == cbgezi.Text) cbgezi.Checked = false;    */
                cıkar(cbfutbol); cıkar(cbgezi); cıkar(cbkitap); cıkar(cbyüzme);

                listBox1.Items.Remove(listBox1.SelectedItem); // secılı olanı lısteden sildik remove kaldırırken kullandıgımız kod du
            }
            else MessageBox.Show("lütfen cıkarmak ıstedgınızı secin");
        }

    }
}
