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

namespace _31_mart
{
    public partial class Form1 : Form
    {
        DialogResult cevap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            int kactane = int.Parse(Interaction.InputBox("kaç tane değer eklensin???")); // cıkan pencereden girilen degeri kactane ye aktardık
            for (int i = 1; i<= kactane;i++,sayi +=2) // bu donguyle kactanedeki sayı kadar ardısık cıft sayı uretıyoruz her seferınde 
             comboBox1.Items.Add( sayi); // tur sonu uretılen sayıyı gosterıyoruz bu kodla comboboxta.biz eklemedıgımızde combox ta sayı olmaz.
            comboBox1.SelectedIndex = 0;
            label2.Text = "eklenen sayı miktarı:" + comboBox1.Items.Count.ToString();
            label1.Text = "seçilen sayı: " + comboBox1.SelectedItem + "   sayının ındexı: " + comboBox1.SelectedIndex;
            label2.Font = new Font(label2.Font.Name, 10);
            label1.Font = new Font(label2.Font.Name, 10);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "seçilen sayı: " + comboBox1.SelectedItem + "   sayının ındexı: " + comboBox1.SelectedIndex;
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            
          cevap = MessageBox.Show("Bilgiler temizlensin mi???", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                comboBox1.Items.Clear();
                label1.Text = "...";
                label2.Text = "eklenen sayı miktarı:" + comboBox1.Items.Count.ToString();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                int tutındex = comboBox1.SelectedIndex;
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.SelectedIndex = tutındex;

                label2.Text = "eklenen sayı miktarı:" + comboBox1.Items.Count.ToString();
                label1.Text = "seçilen sayı: " + comboBox1.SelectedItem + "   sayının ındexı: " + comboBox1.SelectedIndex;
            }
            else MessageBox.Show("lütfen seçim yapın!!!");
        }

        private void btnyerlestir_Click(object sender, EventArgs e)
        {
            int nereye = int.Parse(Interaction.InputBox("Hangi sıraya yerleştirilsin"));
            int deger = int.Parse(Interaction.InputBox("Hangi değer yerleştirilsin"));
            comboBox1.Items.Insert(nereye, deger);
            comboBox1.SelectedIndex = nereye;
            label2.Text = "Madde sayısı: " + comboBox1.Items.Count.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // formun kapatılıyorken engellenmesi için formclosıng eventsını kulllandık
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string sifre = Interaction.InputBox("çıkış için şifre girin");
                if (sifre!="deneme")
                {
                    e.Cancel = true; // formun kapatılmasını engellıyor
                    progressBar1.Maximum = 100;
                    for (int i=100; i>=0;i--)
                    {
                        progressBar1.Value = i;
                        System.Threading.Thread.Sleep(10);
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q) this.Close(); // eger ctrl+q tusuna basılırsa formu kapat dedik
        }
    }
}
