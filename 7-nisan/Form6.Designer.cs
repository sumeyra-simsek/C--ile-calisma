namespace _7_nisan
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "071232",
            "ahmet",
            "yılmaz"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "232232",
            "ayşe",
            "simsek"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbnumara = new System.Windows.Forms.ListBox();
            this.lbad = new System.Windows.Forms.ListBox();
            this.lbsoyad = new System.Windows.Forms.ListBox();
            this.rbartan = new System.Windows.Forms.RadioButton();
            this.rbazalan = new System.Windows.Forms.RadioButton();
            this.Numara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numara,
            this.Adı,
            this.Soyadı});
            this.listView1.FullRowSelect = true;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 147);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // lbnumara
            // 
            this.lbnumara.FormattingEnabled = true;
            this.lbnumara.Location = new System.Drawing.Point(321, 12);
            this.lbnumara.Name = "lbnumara";
            this.lbnumara.Size = new System.Drawing.Size(108, 147);
            this.lbnumara.TabIndex = 1;
            // 
            // lbad
            // 
            this.lbad.FormattingEnabled = true;
            this.lbad.Location = new System.Drawing.Point(435, 12);
            this.lbad.Name = "lbad";
            this.lbad.Size = new System.Drawing.Size(108, 147);
            this.lbad.TabIndex = 2;
            // 
            // lbsoyad
            // 
            this.lbsoyad.FormattingEnabled = true;
            this.lbsoyad.Location = new System.Drawing.Point(549, 12);
            this.lbsoyad.Name = "lbsoyad";
            this.lbsoyad.Size = new System.Drawing.Size(108, 147);
            this.lbsoyad.TabIndex = 3;
            // 
            // rbartan
            // 
            this.rbartan.AutoSize = true;
            this.rbartan.Location = new System.Drawing.Point(12, 211);
            this.rbartan.Name = "rbartan";
            this.rbartan.Size = new System.Drawing.Size(91, 17);
            this.rbartan.TabIndex = 4;
            this.rbartan.TabStop = true;
            this.rbartan.Text = "Artan sıralama";
            this.rbartan.UseVisualStyleBackColor = true;
            this.rbartan.Click += new System.EventHandler(this.rbartan_Click);
            // 
            // rbazalan
            // 
            this.rbazalan.AutoSize = true;
            this.rbazalan.Location = new System.Drawing.Point(149, 211);
            this.rbazalan.Name = "rbazalan";
            this.rbazalan.Size = new System.Drawing.Size(98, 17);
            this.rbazalan.TabIndex = 5;
            this.rbazalan.TabStop = true;
            this.rbazalan.Text = "Azalan sıralama";
            this.rbazalan.UseVisualStyleBackColor = true;
            this.rbazalan.Click += new System.EventHandler(this.rbazalan_Click);
            // 
            // Numara
            // 
            this.Numara.Text = "Numara";
            // 
            // Adı
            // 
            this.Adı.Text = "Adı";
            // 
            // Soyadı
            // 
            this.Soyadı.Text = "Soyadı";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 295);
            this.Controls.Add(this.rbazalan);
            this.Controls.Add(this.rbartan);
            this.Controls.Add(this.lbsoyad);
            this.Controls.Add(this.lbad);
            this.Controls.Add(this.lbnumara);
            this.Controls.Add(this.listView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numara;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader Soyadı;
        private System.Windows.Forms.ListBox lbnumara;
        private System.Windows.Forms.ListBox lbad;
        private System.Windows.Forms.ListBox lbsoyad;
        private System.Windows.Forms.RadioButton rbartan;
        private System.Windows.Forms.RadioButton rbazalan;
    }
}