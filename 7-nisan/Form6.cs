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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            lbnumara.Items.Add(listView1.SelectedItems[0].Text);
            lbad.Items.Add(listView1.SelectedItems[0].SubItems[1].Text);
            lbsoyad.Items.Add(listView1.SelectedItems[0].SubItems[2].Text);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        
        void ekle (string n,string a,string s)
        {
            ListViewItem item = new ListViewItem();
            item.Text = n;
            item.SubItems.Add(a);
            item.SubItems.Add(s);
            listView1.Items.Add(item);
                
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ekle("234654", "aslı", "enver"); 
                
        }

        private void rbartan_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending; // a dan zye sıralama ascendıng

        }

        private void rbazalan_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Descending; // z den aya sıralama descendıng
        }
    }
}
