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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int tutkonum;

        private void Form3_Load(object sender, EventArgs e)
        {
            tutkonum = panel1.Left; // panelin açık durumundaki left konumu
            panel1.Left = 20 - panel1.Width; // paneli kapatma kodu. dısarda 20br kalacak sekılde yazdık. (20-panelın boyu) nu aktardık left konumuna.
        }

        private void panel1_MouseEnter(object sender, EventArgs e) // maus panele giriş yaptıgında yapılacakları yazdık bu events a
        {
            for (int i=panel1.Left; i<= tutkonum;i+=2) // tutkonum panelin bastaki konumu.paneli biz sola kaydırdık dısarda 20br kalacak sekılde. dongunun her seferınde i iki artıyor
            {
                panel1.Left = i; // artan  i yi panele aktarıyoruz i yi dongunun basında zaten panele esitlemıstık her seferınde paneli arttırıyoruz.arttıkca saga dogru gelıyor.tutkonum degıskenıne yanı bastakı konumuna esıtlenınce dongu bıtecek.
                System.Threading.Thread.Sleep(1); // her tur 1 sure sürsün istedik
            }
        }

       

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            for (int i = panel1.Left; i >= 20 - panel1.Width; i -= 2)
            {
                panel1.Left = i;
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
