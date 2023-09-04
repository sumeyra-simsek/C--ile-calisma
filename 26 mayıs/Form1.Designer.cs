namespace _26_mayıs
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.abdadi = new System.Windows.Forms.TextBox();
            this.abdkodu = new System.Windows.Forms.TextBox();
            this.badi = new System.Windows.Forms.ComboBox();
            this.lbabdadi = new System.Windows.Forms.Label();
            this.lbabdkodu = new System.Windows.Forms.Label();
            this.lbbolumadi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.badiara = new System.Windows.Forms.ComboBox();
            this.tbaranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.abdadi);
            this.groupBox1.Controls.Add(this.abdkodu);
            this.groupBox1.Controls.Add(this.badi);
            this.groupBox1.Controls.Add(this.lbabdadi);
            this.groupBox1.Controls.Add(this.lbabdkodu);
            this.groupBox1.Controls.Add(this.lbbolumadi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "anabilim dalı tanımları";
            // 
            // abdadi
            // 
            this.abdadi.Location = new System.Drawing.Point(121, 87);
            this.abdadi.Name = "abdadi";
            this.abdadi.Size = new System.Drawing.Size(207, 20);
            this.abdadi.TabIndex = 5;
            // 
            // abdkodu
            // 
            this.abdkodu.Location = new System.Drawing.Point(121, 58);
            this.abdkodu.Name = "abdkodu";
            this.abdkodu.Size = new System.Drawing.Size(207, 20);
            this.abdkodu.TabIndex = 4;
            // 
            // badi
            // 
            this.badi.FormattingEnabled = true;
            this.badi.Location = new System.Drawing.Point(121, 23);
            this.badi.Name = "badi";
            this.badi.Size = new System.Drawing.Size(207, 21);
            this.badi.TabIndex = 3;
            // 
            // lbabdadi
            // 
            this.lbabdadi.AutoSize = true;
            this.lbabdadi.Location = new System.Drawing.Point(16, 87);
            this.lbabdadi.Name = "lbabdadi";
            this.lbabdadi.Size = new System.Drawing.Size(88, 13);
            this.lbabdadi.TabIndex = 2;
            this.lbabdadi.Text = "Anabilim dalı adı :";
            // 
            // lbabdkodu
            // 
            this.lbabdkodu.AutoSize = true;
            this.lbabdkodu.Location = new System.Drawing.Point(16, 58);
            this.lbabdkodu.Name = "lbabdkodu";
            this.lbabdkodu.Size = new System.Drawing.Size(98, 13);
            this.lbabdkodu.TabIndex = 1;
            this.lbabdkodu.Text = "Anabilim dalı kodu :";
            // 
            // lbbolumadi
            // 
            this.lbbolumadi.AutoSize = true;
            this.lbbolumadi.Location = new System.Drawing.Point(16, 26);
            this.lbbolumadi.Name = "lbbolumadi";
            this.lbbolumadi.Size = new System.Drawing.Size(62, 13);
            this.lbbolumadi.TabIndex = 0;
            this.lbbolumadi.Text = "Bölüm adı : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btniptal);
            this.groupBox2.Controls.Add(this.btnyenikayit);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btngeri);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnduzelt);
            this.groupBox2.Controls.Add(this.btnileri);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "işlemler";
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btniptal.Location = new System.Drawing.Point(202, 60);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnyenikayit.Location = new System.Drawing.Point(6, 31);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(75, 23);
            this.btnyenikayit.TabIndex = 5;
            this.btnyenikayit.Text = "Yeni kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = false;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkaydet.Location = new System.Drawing.Point(249, 31);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngeri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btngeri.Location = new System.Drawing.Point(39, 60);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 23);
            this.btngeri.TabIndex = 0;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsil.Location = new System.Drawing.Point(121, 60);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnduzelt.Location = new System.Drawing.Point(168, 31);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(75, 23);
            this.btnduzelt.TabIndex = 2;
            this.btnduzelt.Text = "Düzelt";
            this.btnduzelt.UseVisualStyleBackColor = false;
            // 
            // btnileri
            // 
            this.btnileri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnileri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnileri.Location = new System.Drawing.Point(87, 31);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(75, 23);
            this.btnileri.TabIndex = 1;
            this.btnileri.Text = "İleri";
            this.btnileri.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.badiara);
            this.groupBox3.Controls.Add(this.tbaranan);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(352, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 350);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listeleme ve arama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 238);
            this.dataGridView1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Tüm kayıtları göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // badiara
            // 
            this.badiara.FormattingEnabled = true;
            this.badiara.Location = new System.Drawing.Point(108, 50);
            this.badiara.Name = "badiara";
            this.badiara.Size = new System.Drawing.Size(157, 21);
            this.badiara.TabIndex = 3;
            // 
            // tbaranan
            // 
            this.tbaranan.Location = new System.Drawing.Point(108, 19);
            this.tbaranan.Name = "tbaranan";
            this.tbaranan.Size = new System.Drawing.Size(157, 20);
            this.tbaranan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anabilim dalı adı :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bolumad";
            this.Column1.HeaderText = "Bölüm adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "abdadi";
            this.Column2.HeaderText = "Anabilim dalı adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "abdkodu";
            this.Column3.HeaderText = "Anabilim dalı kodu";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 374);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox abdadi;
        private System.Windows.Forms.TextBox abdkodu;
        private System.Windows.Forms.ComboBox badi;
        private System.Windows.Forms.Label lbabdadi;
        private System.Windows.Forms.Label lbabdkodu;
        private System.Windows.Forms.Label lbbolumadi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox badiara;
        private System.Windows.Forms.TextBox tbaranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

