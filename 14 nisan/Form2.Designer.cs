namespace _14_nisan
{
    partial class Form2
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
            this.gbıslemler = new System.Windows.Forms.GroupBox();
            this.gbkayıtlar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lbka = new System.Windows.Forms.Label();
            this.lbsf = new System.Windows.Forms.Label();
            this.lbad = new System.Windows.Forms.Label();
            this.lbsoyad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbka = new System.Windows.Forms.TextBox();
            this.tbsf = new System.Windows.Forms.TextBox();
            this.tbad = new System.Windows.Forms.TextBox();
            this.tbsoyad = new System.Windows.Forms.TextBox();
            this.btnyenı = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnsıl = new System.Windows.Forms.Button();
            this.btntamam = new System.Windows.Forms.Button();
            this.btnıptal = new System.Windows.Forms.Button();
            this.gbıslemler.SuspendLayout();
            this.gbkayıtlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbıslemler
            // 
            this.gbıslemler.BackColor = System.Drawing.SystemColors.Window;
            this.gbıslemler.Controls.Add(this.btnıptal);
            this.gbıslemler.Controls.Add(this.btntamam);
            this.gbıslemler.Controls.Add(this.btnsıl);
            this.gbıslemler.Controls.Add(this.btnduzelt);
            this.gbıslemler.Controls.Add(this.btnyenı);
            this.gbıslemler.Location = new System.Drawing.Point(18, 118);
            this.gbıslemler.Name = "gbıslemler";
            this.gbıslemler.Size = new System.Drawing.Size(479, 62);
            this.gbıslemler.TabIndex = 0;
            this.gbıslemler.TabStop = false;
            this.gbıslemler.Text = "işlemler";
            // 
            // gbkayıtlar
            // 
            this.gbkayıtlar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbkayıtlar.Controls.Add(this.dataGridView1);
            this.gbkayıtlar.Location = new System.Drawing.Point(12, 196);
            this.gbkayıtlar.Name = "gbkayıtlar";
            this.gbkayıtlar.Size = new System.Drawing.Size(485, 207);
            this.gbkayıtlar.TabIndex = 1;
            this.gbkayıtlar.TabStop = false;
            this.gbkayıtlar.Text = "kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb.Controls.Add(this.tbsoyad);
            this.gb.Controls.Add(this.tbad);
            this.gb.Controls.Add(this.tbsf);
            this.gb.Controls.Add(this.tbka);
            this.gb.Controls.Add(this.lbsoyad);
            this.gb.Controls.Add(this.lbad);
            this.gb.Controls.Add(this.lbsf);
            this.gb.Controls.Add(this.lbka);
            this.gb.Location = new System.Drawing.Point(18, 22);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(479, 90);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            // 
            // lbka
            // 
            this.lbka.AutoSize = true;
            this.lbka.Location = new System.Drawing.Point(24, 33);
            this.lbka.Name = "lbka";
            this.lbka.Size = new System.Drawing.Size(68, 13);
            this.lbka.TabIndex = 0;
            this.lbka.Text = "kullanıcı adı :";
            // 
            // lbsf
            // 
            this.lbsf.AutoSize = true;
            this.lbsf.Location = new System.Drawing.Point(57, 59);
            this.lbsf.Name = "lbsf";
            this.lbsf.Size = new System.Drawing.Size(35, 13);
            this.lbsf.TabIndex = 1;
            this.lbsf.Text = "şifre : ";
            // 
            // lbad
            // 
            this.lbad.AutoSize = true;
            this.lbad.Location = new System.Drawing.Point(277, 36);
            this.lbad.Name = "lbad";
            this.lbad.Size = new System.Drawing.Size(27, 13);
            this.lbad.TabIndex = 2;
            this.lbad.Text = "adı :";
            // 
            // lbsoyad
            // 
            this.lbsoyad.AutoSize = true;
            this.lbsoyad.Location = new System.Drawing.Point(258, 66);
            this.lbsoyad.Name = "lbsoyad";
            this.lbsoyad.Size = new System.Drawing.Size(46, 13);
            this.lbsoyad.TabIndex = 3;
            this.lbsoyad.Text = "soyadı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // tbka
            // 
            this.tbka.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbka.Location = new System.Drawing.Point(98, 33);
            this.tbka.Name = "tbka";
            this.tbka.Size = new System.Drawing.Size(111, 20);
            this.tbka.TabIndex = 4;
            // 
            // tbsf
            // 
            this.tbsf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsf.Location = new System.Drawing.Point(98, 59);
            this.tbsf.Name = "tbsf";
            this.tbsf.Size = new System.Drawing.Size(111, 20);
            this.tbsf.TabIndex = 5;
            // 
            // tbad
            // 
            this.tbad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbad.Location = new System.Drawing.Point(310, 33);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(148, 20);
            this.tbad.TabIndex = 6;
            // 
            // tbsoyad
            // 
            this.tbsoyad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsoyad.Location = new System.Drawing.Point(310, 63);
            this.tbsoyad.Name = "tbsoyad";
            this.tbsoyad.Size = new System.Drawing.Size(148, 20);
            this.tbsoyad.TabIndex = 7;
            // 
            // btnyenı
            // 
            this.btnyenı.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnyenı.Location = new System.Drawing.Point(6, 19);
            this.btnyenı.Name = "btnyenı";
            this.btnyenı.Size = new System.Drawing.Size(75, 23);
            this.btnyenı.TabIndex = 0;
            this.btnyenı.Text = "yeni";
            this.btnyenı.UseVisualStyleBackColor = false;
            this.btnyenı.Click += new System.EventHandler(this.btnyenı_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnduzelt.Location = new System.Drawing.Point(90, 19);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(75, 23);
            this.btnduzelt.TabIndex = 1;
            this.btnduzelt.Text = "düzelt";
            this.btnduzelt.UseVisualStyleBackColor = false;
            // 
            // btnsıl
            // 
            this.btnsıl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsıl.Location = new System.Drawing.Point(171, 19);
            this.btnsıl.Name = "btnsıl";
            this.btnsıl.Size = new System.Drawing.Size(75, 23);
            this.btnsıl.TabIndex = 2;
            this.btnsıl.Text = "sil";
            this.btnsıl.UseVisualStyleBackColor = false;
            // 
            // btntamam
            // 
            this.btntamam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btntamam.Location = new System.Drawing.Point(298, 19);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(75, 23);
            this.btntamam.TabIndex = 3;
            this.btntamam.Text = "tamam";
            this.btntamam.UseVisualStyleBackColor = false;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // btnıptal
            // 
            this.btnıptal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnıptal.Location = new System.Drawing.Point(383, 19);
            this.btnıptal.Name = "btnıptal";
            this.btnıptal.Size = new System.Drawing.Size(75, 23);
            this.btnıptal.TabIndex = 4;
            this.btnıptal.Text = "iptal";
            this.btnıptal.UseVisualStyleBackColor = false;
            this.btnıptal.Click += new System.EventHandler(this.btnıptal_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.gbkayıtlar);
            this.Controls.Add(this.gbıslemler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbıslemler.ResumeLayout(false);
            this.gbkayıtlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbıslemler;
        private System.Windows.Forms.Button btnıptal;
        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.Button btnsıl;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnyenı;
        private System.Windows.Forms.GroupBox gbkayıtlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox tbsoyad;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.TextBox tbsf;
        private System.Windows.Forms.TextBox tbka;
        private System.Windows.Forms.Label lbsoyad;
        private System.Windows.Forms.Label lbad;
        private System.Windows.Forms.Label lbsf;
        private System.Windows.Forms.Label lbka;
        private System.Windows.Forms.Label label5;
    }
}