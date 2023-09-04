namespace Hafta2
{
    partial class Form4
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
            this.gbmedenihal = new System.Windows.Forms.GroupBox();
            this.rbevli = new System.Windows.Forms.RadioButton();
            this.rbbekar = new System.Windows.Forms.RadioButton();
            this.rbdul = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbogrenimdurumu = new System.Windows.Forms.GroupBox();
            this.gbhobiler = new System.Windows.Forms.GroupBox();
            this.rblisans = new System.Windows.Forms.RadioButton();
            this.rbortaokul = new System.Windows.Forms.RadioButton();
            this.rblise = new System.Windows.Forms.RadioButton();
            this.rblisansustu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbyüzme = new System.Windows.Forms.CheckBox();
            this.cbfutbol = new System.Windows.Forms.CheckBox();
            this.cbgezi = new System.Windows.Forms.CheckBox();
            this.cbkitap = new System.Windows.Forms.CheckBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btncıkar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbmedenihal.SuspendLayout();
            this.gbogrenimdurumu.SuspendLayout();
            this.gbhobiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbmedenihal
            // 
            this.gbmedenihal.Controls.Add(this.label1);
            this.gbmedenihal.Controls.Add(this.rbdul);
            this.gbmedenihal.Controls.Add(this.rbbekar);
            this.gbmedenihal.Controls.Add(this.rbevli);
            this.gbmedenihal.Location = new System.Drawing.Point(31, 12);
            this.gbmedenihal.Name = "gbmedenihal";
            this.gbmedenihal.Size = new System.Drawing.Size(554, 56);
            this.gbmedenihal.TabIndex = 0;
            this.gbmedenihal.TabStop = false;
            this.gbmedenihal.Text = "Medeni hal";
            // 
            // rbevli
            // 
            this.rbevli.AutoSize = true;
            this.rbevli.Location = new System.Drawing.Point(7, 19);
            this.rbevli.Name = "rbevli";
            this.rbevli.Size = new System.Drawing.Size(41, 17);
            this.rbevli.TabIndex = 0;
            this.rbevli.TabStop = true;
            this.rbevli.Text = "evli";
            this.rbevli.UseVisualStyleBackColor = true;
            this.rbevli.CheckedChanged += new System.EventHandler(this.rbevli_CheckedChanged);
            // 
            // rbbekar
            // 
            this.rbbekar.AutoSize = true;
            this.rbbekar.Location = new System.Drawing.Point(115, 19);
            this.rbbekar.Name = "rbbekar";
            this.rbbekar.Size = new System.Drawing.Size(52, 17);
            this.rbbekar.TabIndex = 1;
            this.rbbekar.TabStop = true;
            this.rbbekar.Text = "bekar";
            this.rbbekar.UseVisualStyleBackColor = true;
            this.rbbekar.CheckedChanged += new System.EventHandler(this.rbbekar_CheckedChanged);
            // 
            // rbdul
            // 
            this.rbdul.AutoSize = true;
            this.rbdul.Location = new System.Drawing.Point(223, 19);
            this.rbdul.Name = "rbdul";
            this.rbdul.Size = new System.Drawing.Size(39, 17);
            this.rbdul.TabIndex = 2;
            this.rbdul.TabStop = true;
            this.rbdul.Text = "dul";
            this.rbdul.UseVisualStyleBackColor = true;
            this.rbdul.CheckedChanged += new System.EventHandler(this.rbdul_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // gbogrenimdurumu
            // 
            this.gbogrenimdurumu.Controls.Add(this.label2);
            this.gbogrenimdurumu.Controls.Add(this.rblisansustu);
            this.gbogrenimdurumu.Controls.Add(this.rblise);
            this.gbogrenimdurumu.Controls.Add(this.rbortaokul);
            this.gbogrenimdurumu.Controls.Add(this.rblisans);
            this.gbogrenimdurumu.Location = new System.Drawing.Point(31, 91);
            this.gbogrenimdurumu.Name = "gbogrenimdurumu";
            this.gbogrenimdurumu.Size = new System.Drawing.Size(554, 64);
            this.gbogrenimdurumu.TabIndex = 1;
            this.gbogrenimdurumu.TabStop = false;
            this.gbogrenimdurumu.Text = "öğrenim durumu";
            // 
            // gbhobiler
            // 
            this.gbhobiler.Controls.Add(this.listBox1);
            this.gbhobiler.Controls.Add(this.btncıkar);
            this.gbhobiler.Controls.Add(this.btnekle);
            this.gbhobiler.Controls.Add(this.cbkitap);
            this.gbhobiler.Controls.Add(this.cbgezi);
            this.gbhobiler.Controls.Add(this.cbfutbol);
            this.gbhobiler.Controls.Add(this.cbyüzme);
            this.gbhobiler.Location = new System.Drawing.Point(31, 171);
            this.gbhobiler.Name = "gbhobiler";
            this.gbhobiler.Size = new System.Drawing.Size(554, 148);
            this.gbhobiler.TabIndex = 2;
            this.gbhobiler.TabStop = false;
            this.gbhobiler.Text = "Hobiler";
            // 
            // rblisans
            // 
            this.rblisans.AutoSize = true;
            this.rblisans.Location = new System.Drawing.Point(167, 22);
            this.rblisans.Name = "rblisans";
            this.rblisans.Size = new System.Drawing.Size(55, 17);
            this.rblisans.TabIndex = 0;
            this.rblisans.TabStop = true;
            this.rblisans.Text = "Lisans";
            this.rblisans.UseVisualStyleBackColor = true;
            this.rblisans.CheckedChanged += new System.EventHandler(this.rblisans_CheckedChanged);
            // 
            // rbortaokul
            // 
            this.rbortaokul.AutoSize = true;
            this.rbortaokul.Location = new System.Drawing.Point(17, 22);
            this.rbortaokul.Name = "rbortaokul";
            this.rbortaokul.Size = new System.Drawing.Size(63, 17);
            this.rbortaokul.TabIndex = 1;
            this.rbortaokul.TabStop = true;
            this.rbortaokul.Text = "ortaokul";
            this.rbortaokul.UseVisualStyleBackColor = true;
            this.rbortaokul.CheckedChanged += new System.EventHandler(this.rbortaokul_CheckedChanged);
            // 
            // rblise
            // 
            this.rblise.AutoSize = true;
            this.rblise.Location = new System.Drawing.Point(103, 22);
            this.rblise.Name = "rblise";
            this.rblise.Size = new System.Drawing.Size(40, 17);
            this.rblise.TabIndex = 2;
            this.rblise.TabStop = true;
            this.rblise.Text = "lise";
            this.rblise.UseVisualStyleBackColor = true;
            this.rblise.CheckedChanged += new System.EventHandler(this.rblise_CheckedChanged);
            // 
            // rblisansustu
            // 
            this.rblisansustu.AutoSize = true;
            this.rblisansustu.Location = new System.Drawing.Point(260, 22);
            this.rblisansustu.Name = "rblisansustu";
            this.rblisansustu.Size = new System.Drawing.Size(75, 17);
            this.rblisansustu.TabIndex = 3;
            this.rblisansustu.TabStop = true;
            this.rblisansustu.Text = "Lisansüstü";
            this.rblisansustu.UseVisualStyleBackColor = true;
            this.rblisansustu.CheckedChanged += new System.EventHandler(this.rblisansustu_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // cbyüzme
            // 
            this.cbyüzme.AutoSize = true;
            this.cbyüzme.Location = new System.Drawing.Point(17, 30);
            this.cbyüzme.Name = "cbyüzme";
            this.cbyüzme.Size = new System.Drawing.Size(56, 17);
            this.cbyüzme.TabIndex = 0;
            this.cbyüzme.Text = "yüzme";
            this.cbyüzme.UseVisualStyleBackColor = true;
            // 
            // cbfutbol
            // 
            this.cbfutbol.AutoSize = true;
            this.cbfutbol.Location = new System.Drawing.Point(17, 65);
            this.cbfutbol.Name = "cbfutbol";
            this.cbfutbol.Size = new System.Drawing.Size(52, 17);
            this.cbfutbol.TabIndex = 1;
            this.cbfutbol.Text = "futbol";
            this.cbfutbol.UseVisualStyleBackColor = true;
            // 
            // cbgezi
            // 
            this.cbgezi.AutoSize = true;
            this.cbgezi.Location = new System.Drawing.Point(115, 30);
            this.cbgezi.Name = "cbgezi";
            this.cbgezi.Size = new System.Drawing.Size(45, 17);
            this.cbgezi.TabIndex = 2;
            this.cbgezi.Text = "gezi";
            this.cbgezi.UseVisualStyleBackColor = true;
            // 
            // cbkitap
            // 
            this.cbkitap.AutoSize = true;
            this.cbkitap.Location = new System.Drawing.Point(115, 65);
            this.cbkitap.Name = "cbkitap";
            this.cbkitap.Size = new System.Drawing.Size(49, 17);
            this.cbkitap.TabIndex = 3;
            this.cbkitap.Text = "kitap";
            this.cbkitap.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(223, 26);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btncıkar
            // 
            this.btncıkar.Location = new System.Drawing.Point(223, 65);
            this.btncıkar.Name = "btncıkar";
            this.btncıkar.Size = new System.Drawing.Size(75, 23);
            this.btncıkar.TabIndex = 5;
            this.btncıkar.Text = "çıkar";
            this.btncıkar.UseVisualStyleBackColor = true;
            this.btncıkar.Click += new System.EventHandler(this.btncıkar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(352, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 387);
            this.Controls.Add(this.gbhobiler);
            this.Controls.Add(this.gbogrenimdurumu);
            this.Controls.Add(this.gbmedenihal);
            this.Name = "Form4";
            this.Text = "Form4";
            this.gbmedenihal.ResumeLayout(false);
            this.gbmedenihal.PerformLayout();
            this.gbogrenimdurumu.ResumeLayout(false);
            this.gbogrenimdurumu.PerformLayout();
            this.gbhobiler.ResumeLayout(false);
            this.gbhobiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmedenihal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbdul;
        private System.Windows.Forms.RadioButton rbbekar;
        private System.Windows.Forms.RadioButton rbevli;
        private System.Windows.Forms.GroupBox gbogrenimdurumu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rblisansustu;
        private System.Windows.Forms.RadioButton rblise;
        private System.Windows.Forms.RadioButton rbortaokul;
        private System.Windows.Forms.RadioButton rblisans;
        private System.Windows.Forms.GroupBox gbhobiler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btncıkar;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.CheckBox cbkitap;
        private System.Windows.Forms.CheckBox cbgezi;
        private System.Windows.Forms.CheckBox cbfutbol;
        private System.Windows.Forms.CheckBox cbyüzme;
    }
}