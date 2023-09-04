namespace _14_nisan
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
            this.gbekleme = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.tbadet = new System.Windows.Forms.TextBox();
            this.labeladet = new System.Windows.Forms.Label();
            this.gbsecilen = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbucretler = new System.Windows.Forms.GroupBox();
            this.tbbirimucret = new System.Windows.Forms.TextBox();
            this.btnucrethesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelbirimücret = new System.Windows.Forms.Label();
            this.gbekleme.SuspendLayout();
            this.gbsecilen.SuspendLayout();
            this.gbucretler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbekleme
            // 
            this.gbekleme.Controls.Add(this.btnekle);
            this.gbekleme.Controls.Add(this.tbadet);
            this.gbekleme.Controls.Add(this.labeladet);
            this.gbekleme.Location = new System.Drawing.Point(12, 3);
            this.gbekleme.Name = "gbekleme";
            this.gbekleme.Size = new System.Drawing.Size(432, 78);
            this.gbekleme.TabIndex = 0;
            this.gbekleme.TabStop = false;
            this.gbekleme.Text = "ekleme secenekleri";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(192, 21);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // tbadet
            // 
            this.tbadet.Location = new System.Drawing.Point(57, 23);
            this.tbadet.Name = "tbadet";
            this.tbadet.Size = new System.Drawing.Size(100, 20);
            this.tbadet.TabIndex = 1;
            // 
            // labeladet
            // 
            this.labeladet.AutoSize = true;
            this.labeladet.Location = new System.Drawing.Point(16, 25);
            this.labeladet.Name = "labeladet";
            this.labeladet.Size = new System.Drawing.Size(34, 13);
            this.labeladet.TabIndex = 0;
            this.labeladet.Text = "adet :";
            // 
            // gbsecilen
            // 
            this.gbsecilen.Controls.Add(this.label2);
            this.gbsecilen.Location = new System.Drawing.Point(12, 200);
            this.gbsecilen.Name = "gbsecilen";
            this.gbsecilen.Size = new System.Drawing.Size(432, 57);
            this.gbsecilen.TabIndex = 1;
            this.gbsecilen.TabStop = false;
            this.gbsecilen.Text = "secilen koltuklar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // gbucretler
            // 
            this.gbucretler.Controls.Add(this.tbbirimucret);
            this.gbucretler.Controls.Add(this.btnucrethesapla);
            this.gbucretler.Controls.Add(this.label4);
            this.gbucretler.Controls.Add(this.labelbirimücret);
            this.gbucretler.Location = new System.Drawing.Point(12, 263);
            this.gbucretler.Name = "gbucretler";
            this.gbucretler.Size = new System.Drawing.Size(432, 74);
            this.gbucretler.TabIndex = 2;
            this.gbucretler.TabStop = false;
            this.gbucretler.Text = "ücretler";
            // 
            // tbbirimucret
            // 
            this.tbbirimucret.Location = new System.Drawing.Point(178, 21);
            this.tbbirimucret.Name = "tbbirimucret";
            this.tbbirimucret.Size = new System.Drawing.Size(100, 20);
            this.tbbirimucret.TabIndex = 3;
            // 
            // btnucrethesapla
            // 
            this.btnucrethesapla.Location = new System.Drawing.Point(19, 24);
            this.btnucrethesapla.Name = "btnucrethesapla";
            this.btnucrethesapla.Size = new System.Drawing.Size(75, 36);
            this.btnucrethesapla.TabIndex = 2;
            this.btnucrethesapla.Text = "ücret hesapla";
            this.btnucrethesapla.UseVisualStyleBackColor = true;
            this.btnucrethesapla.Click += new System.EventHandler(this.btnucrethesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(203, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // labelbirimücret
            // 
            this.labelbirimücret.AutoSize = true;
            this.labelbirimücret.Location = new System.Drawing.Point(110, 24);
            this.labelbirimücret.Name = "labelbirimücret";
            this.labelbirimücret.Size = new System.Drawing.Size(62, 13);
            this.labelbirimücret.TabIndex = 0;
            this.labelbirimücret.Text = "Birim ücret :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 349);
            this.Controls.Add(this.gbucretler);
            this.Controls.Add(this.gbsecilen);
            this.Controls.Add(this.gbekleme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbekleme.ResumeLayout(false);
            this.gbekleme.PerformLayout();
            this.gbsecilen.ResumeLayout(false);
            this.gbsecilen.PerformLayout();
            this.gbucretler.ResumeLayout(false);
            this.gbucretler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbekleme;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox tbadet;
        private System.Windows.Forms.Label labeladet;
        private System.Windows.Forms.GroupBox gbsecilen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbucretler;
        private System.Windows.Forms.TextBox tbbirimucret;
        private System.Windows.Forms.Button btnucrethesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelbirimücret;
    }
}

