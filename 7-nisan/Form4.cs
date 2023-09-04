using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_nisan
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e) // form kapanırken olması ıstenen eylemlerı bu eventsa yazıyoruz.
        {
            if (e.CloseReason == CloseReason.UserClosing) // eger kullanıcı cıkısyaparsa yapılacaklar
            {
                e.Cancel = true; // cancel ı kaldırdık yani kontrol tusundan kapatırsak kapanmaz
                notifyIcon1.Visible = true; // bunu true yapmak calıstırmak demek propertıeste ayarlanan mesajı gonderıyor
                notifyIcon1.ShowBalloonTip(1000);
                this.Hide();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
