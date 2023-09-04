using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_mart
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int say = 60;

        private void timer1_Tick(object sender, EventArgs e) // timer 1 in calısırken yapmasını ıstedıgımız seyi tıck koduna yazarız.ıntervalınden de bunu kac milisanıyede bir yapmak istiyor onu ayarlarız.100 yazmıstık biz.
        {
            label1.Text = say.ToString(); // say degerını yukarda 60 ayarladık tımer 1 calıstıgında 60 ı aktarıyor.alt satırdan azaltıyor ve azalttıgını bu satırda tekrar labela yazıyor.sıfır oldugunda ıf dongusune gırıyor.
            say--; 
            if (say <= 0) // sıfıra esıtlenınce tımer 1 ı pasıf yapıyoruz.tımer 2 aktıf oluyor. ve tımer 2 nın tıck kodu calısıyor.
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            say++; // sıfır olan say degıskenını arttırdık
            label1.Text = say.ToString(); // artan degısken labela gecıyor.ust satırdan artıyor sonra tekrar burdan labela aktarılıyor. 60 oldugunda ıf dongusune gırıyor
            if (say >= 60) //60 a ulastıgı ıcın tekrar azalmasını ıstıyoruz bu yuzden tımer 1 ı aktıf tımer 2 yı pasıf yapıyor. 
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void btnsay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // butona basıldıgında tımer 1 aktıf oluyor ve ıslemler baslıyor.
        }
    }
}
