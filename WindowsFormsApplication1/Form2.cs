using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int sayac = 0; // global tanımladık çünkü lokal tanımladıgımızda (btnsay clıck fonksıyonunda) her butona tıklandıgında sayacı 0 a esıtler.döngü sonlanır en basa gelir ve sayac = 0 ile karsılasıp 0 tekrar sıfır olur ve bi yere varamayız.en basa gelınce 1 arttırır bunu else satırında labela yazar sonra en basa cıkar sayac =0 olur ve tekrar 1 arttırır sonra tekrar labela 1 yazar ...uzattım by.
        Color arka, yazı; // bu değişkenler tıklasay butonundan farenın gelıp gıtmesıyle renk degısırken bize yardım ediyor.farenin gelmesiyle renk degişmeden önceki renkleri bu degişkenlere aktaracagız alt satırlarda color türünden global tanımladık istedgimiz yerde kullanacagız.load ve mouseleave /enter da kullandık
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = btnsay.Visible = false; // formun load eventıne yazdıgımız bu komut labeli yani formda cıkacak yazıyı ve butonun birini görünmez yaptı(visible özelliğini false yaptık)
            arka = btntıklasay.BackColor; // bu colorları burda tanımlama nedenimiz arka degiskenine butonun arka rengini atadık butonların önceki renklerini burada aldık vs vs loadda yaptık cunku baska nerde yapcaz bu işi ondan sdkjf anlamadm tam kank devam
            yazı = btntıklasay.ForeColor;
        }

        private void btntıklasay_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("saymak istiyor musunuz?", "onay penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // messageboxun 1 den 21 e kadar kullanım genişliği var 7. kullandık.7. kullanımda 4 parametre var 1. si sana mesaj veriyor,2.si title ın adı ,3.sü sana sunulacak seçenekler (evet hayır),4.sü mesajın yanındakı halka sembolun belirlenmesi.bizim sectiğimiz değer ise (evet yada hayırdan herhangi biri)dialog result türünden sonuc değiskenine aktarılıyor.sectiğimiz değere göre komut yazacağız asagıda.
            if (sonuc == DialogResult.Yes) label1.Visible = btnsay.Visible = true;// evet isaretlendiğinde yapılacak komutu yazdık fark ettiysen yes secenegini dialogresult türü yaptık tür uyuşmazlıgı olmaması için. hayır secenegi için komut yazmıyoruz çünkü orayla işimiz yok 

        }

        private void btnsay_Click(object sender, EventArgs e)
        {
            sayac++;  // butona tıklarız sayacı arttırır 1 olur 10 dan büyük olmadıgı için labela kaydolur başa döner yani bu satıra tekrar sayacı arttırır 2 olur bunu yine else den labela aktarır 11 olana kadar 11 olunca if komutunu uygular
            if (sayac > 10)
            {
                label1.Visible = btnsay.Visible = false; // ekranda bu komut gerceklestıkten sonra sadece tıkla say butonu kalıyor ve ona tekrar basıldgında labelın 10 sayısında kaldıgını goruyoruz bunu duzeltmek için bir alt satıra tekrar sayac sıfırlama koyduk.
                sayac = 0; // sayacı sıfırladık. if blogundan cıkınca bu sıfır labela aktsrılıyor ama ekranda gozukmez label ın sıfır oluş anı cunku bır ust satırda labelı görunmez yapmıstık.tekrar tıkla say yaptıgımızda sıfır olarak görebilirz.
            }
           label1.Text = sayac.ToString(); // label ı strıng ,sayac ı ınt tanımlamıstık.tür uyusmazlıgı olmaması için 'tostring' yazarak sayacı strıng yaptık.
            
        }

        private void btntıklasay_MouseEnter(object sender, EventArgs e)
        {
            btntıklasay.BackColor = Color.Red;
            btntıklasay.ForeColor = Color.Black;
        }

        private void btntıklasay_MouseLeave(object sender, EventArgs e)
        {
            btntıklasay.BackColor = arka; // arka ve yazı degıskenlerıne en bastaki rengini load kısmında aktarmıstık sımdı mauseleave ile fare butondan ayrıldıgı zaman o renklerın gelmesını istiyoruz onu yaotıkkkk
            btntıklasay.ForeColor = yazı;
        }
    }
}
