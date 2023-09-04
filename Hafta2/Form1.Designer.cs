namespace Hafta2
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
            this.rbkadin = new System.Windows.Forms.RadioButton();
            this.rberkek = new System.Windows.Forms.RadioButton();
            this.nuyas = new System.Windows.Forms.NumericUpDown();
            this.tbadsoyad = new System.Windows.Forms.TextBox();
            this.tbnumara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnrenkdegistir = new System.Windows.Forms.Button();
            this.rbarkaplanrengi = new System.Windows.Forms.RadioButton();
            this.rbyazirengi = new System.Windows.Forms.RadioButton();
            this.btnmesajver = new System.Windows.Forms.Button();
            this.btnizinver = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuyas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbkadin);
            this.groupBox1.Controls.Add(this.rberkek);
            this.groupBox1.Controls.Add(this.nuyas);
            this.groupBox1.Controls.Add(this.tbadsoyad);
            this.groupBox1.Controls.Add(this.tbnumara);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // rbkadin
            // 
            this.rbkadin.AutoSize = true;
            this.rbkadin.Location = new System.Drawing.Point(262, 99);
            this.rbkadin.Name = "rbkadin";
            this.rbkadin.Size = new System.Drawing.Size(52, 17);
            this.rbkadin.TabIndex = 8;
            this.rbkadin.TabStop = true;
            this.rbkadin.Text = "Kadın";
            this.rbkadin.UseVisualStyleBackColor = true;
            // 
            // rberkek
            // 
            this.rberkek.AutoSize = true;
            this.rberkek.Location = new System.Drawing.Point(133, 99);
            this.rberkek.Name = "rberkek";
            this.rberkek.Size = new System.Drawing.Size(53, 17);
            this.rberkek.TabIndex = 7;
            this.rberkek.TabStop = true;
            this.rberkek.Text = "Erkek";
            this.rberkek.UseVisualStyleBackColor = true;
            // 
            // nuyas
            // 
            this.nuyas.Location = new System.Drawing.Point(133, 121);
            this.nuyas.Name = "nuyas";
            this.nuyas.Size = new System.Drawing.Size(120, 20);
            this.nuyas.TabIndex = 6;
            // 
            // tbadsoyad
            // 
            this.tbadsoyad.Location = new System.Drawing.Point(133, 68);
            this.tbadsoyad.Name = "tbadsoyad";
            this.tbadsoyad.Size = new System.Drawing.Size(134, 20);
            this.tbadsoyad.TabIndex = 5;
            this.tbadsoyad.Enter += new System.EventHandler(this.tbadsoyad_Enter);
            this.tbadsoyad.Leave += new System.EventHandler(this.tbadsoyad_Leave);
            // 
            // tbnumara
            // 
            this.tbnumara.Location = new System.Drawing.Point(133, 38);
            this.tbnumara.Name = "tbnumara";
            this.tbnumara.Size = new System.Drawing.Size(134, 20);
            this.tbnumara.TabIndex = 4;
            this.tbnumara.Enter += new System.EventHandler(this.tbnumara_Enter);
            this.tbnumara.Leave += new System.EventHandler(this.tbnumara_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "adı ve soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnrenkdegistir);
            this.groupBox2.Controls.Add(this.rbarkaplanrengi);
            this.groupBox2.Controls.Add(this.rbyazirengi);
            this.groupBox2.Controls.Add(this.btnmesajver);
            this.groupBox2.Controls.Add(this.btnizinver);
            this.groupBox2.Location = new System.Drawing.Point(26, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "işlemler";
            // 
            // btnrenkdegistir
            // 
            this.btnrenkdegistir.Location = new System.Drawing.Point(162, 51);
            this.btnrenkdegistir.Name = "btnrenkdegistir";
            this.btnrenkdegistir.Size = new System.Drawing.Size(75, 23);
            this.btnrenkdegistir.TabIndex = 4;
            this.btnrenkdegistir.Text = "renk değiştir";
            this.btnrenkdegistir.UseVisualStyleBackColor = true;
            this.btnrenkdegistir.Click += new System.EventHandler(this.btnrenkdegistir_Click);
            // 
            // rbarkaplanrengi
            // 
            this.rbarkaplanrengi.AutoSize = true;
            this.rbarkaplanrengi.Location = new System.Drawing.Point(278, 65);
            this.rbarkaplanrengi.Name = "rbarkaplanrengi";
            this.rbarkaplanrengi.Size = new System.Drawing.Size(95, 17);
            this.rbarkaplanrengi.TabIndex = 3;
            this.rbarkaplanrengi.TabStop = true;
            this.rbarkaplanrengi.Text = "arka plan rengi";
            this.rbarkaplanrengi.UseVisualStyleBackColor = true;
            // 
            // rbyazirengi
            // 
            this.rbyazirengi.AutoSize = true;
            this.rbyazirengi.Location = new System.Drawing.Point(278, 31);
            this.rbyazirengi.Name = "rbyazirengi";
            this.rbyazirengi.Size = new System.Drawing.Size(69, 17);
            this.rbyazirengi.TabIndex = 2;
            this.rbyazirengi.TabStop = true;
            this.rbyazirengi.Text = "yazı rengi";
            this.rbyazirengi.UseVisualStyleBackColor = true;
            // 
            // btnmesajver
            // 
            this.btnmesajver.Location = new System.Drawing.Point(52, 65);
            this.btnmesajver.Name = "btnmesajver";
            this.btnmesajver.Size = new System.Drawing.Size(75, 23);
            this.btnmesajver.TabIndex = 1;
            this.btnmesajver.Text = "mesaj ver";
            this.btnmesajver.UseVisualStyleBackColor = true;
            this.btnmesajver.Click += new System.EventHandler(this.btnmesajver_Click);
            // 
            // btnizinver
            // 
            this.btnizinver.Location = new System.Drawing.Point(52, 31);
            this.btnizinver.Name = "btnizinver";
            this.btnizinver.Size = new System.Drawing.Size(75, 23);
            this.btnizinver.TabIndex = 0;
            this.btnizinver.Text = "izin ver";
            this.btnizinver.UseVisualStyleBackColor = true;
            this.btnizinver.Click += new System.EventHandler(this.btnizinver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuyas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbkadin;
        private System.Windows.Forms.RadioButton rberkek;
        private System.Windows.Forms.NumericUpDown nuyas;
        private System.Windows.Forms.TextBox tbadsoyad;
        private System.Windows.Forms.TextBox tbnumara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnrenkdegistir;
        private System.Windows.Forms.RadioButton rbarkaplanrengi;
        private System.Windows.Forms.RadioButton rbyazirengi;
        private System.Windows.Forms.Button btnmesajver;
        private System.Windows.Forms.Button btnizinver;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

