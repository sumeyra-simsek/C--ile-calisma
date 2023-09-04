namespace Hafta2
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnyashesapla = new System.Windows.Forms.Button();
            this.btnyasgelsin = new System.Windows.Forms.Button();
            this.btnyasgitsin = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.dtpdtarihi = new System.Windows.Forms.DateTimePicker();
            this.trackbar = new System.Windows.Forms.TrackBar();
            this.btnyasrengi = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "doğum tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(447, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnyashesapla
            // 
            this.btnyashesapla.Location = new System.Drawing.Point(367, 19);
            this.btnyashesapla.Name = "btnyashesapla";
            this.btnyashesapla.Size = new System.Drawing.Size(75, 23);
            this.btnyashesapla.TabIndex = 3;
            this.btnyashesapla.Text = "yaşı hesapla";
            this.btnyashesapla.UseVisualStyleBackColor = true;
            this.btnyashesapla.Click += new System.EventHandler(this.btnyashesapla_Click);
            // 
            // btnyasgelsin
            // 
            this.btnyasgelsin.Location = new System.Drawing.Point(57, 118);
            this.btnyasgelsin.Name = "btnyasgelsin";
            this.btnyasgelsin.Size = new System.Drawing.Size(75, 23);
            this.btnyasgelsin.TabIndex = 4;
            this.btnyasgelsin.Text = "yaş gelsin";
            this.btnyasgelsin.UseVisualStyleBackColor = true;
            this.btnyasgelsin.Click += new System.EventHandler(this.btnyasgelsin_Click);
            // 
            // btnyasgitsin
            // 
            this.btnyasgitsin.Location = new System.Drawing.Point(161, 118);
            this.btnyasgitsin.Name = "btnyasgitsin";
            this.btnyasgitsin.Size = new System.Drawing.Size(75, 23);
            this.btnyasgitsin.TabIndex = 5;
            this.btnyasgitsin.Text = "yaş gitsin";
            this.btnyasgitsin.UseVisualStyleBackColor = true;
            this.btnyasgitsin.Click += new System.EventHandler(this.btnyasgitsin_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(406, 194);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(60, 20);
            this.textbox.TabIndex = 7;
            this.textbox.Text = "10";
            this.textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            // 
            // dtpdtarihi
            // 
            this.dtpdtarihi.Location = new System.Drawing.Point(119, 22);
            this.dtpdtarihi.Name = "dtpdtarihi";
            this.dtpdtarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpdtarihi.TabIndex = 8;
            // 
            // trackbar
            // 
            this.trackbar.Location = new System.Drawing.Point(421, 75);
            this.trackbar.Maximum = 300;
            this.trackbar.Minimum = 10;
            this.trackbar.Name = "trackbar";
            this.trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbar.Size = new System.Drawing.Size(45, 104);
            this.trackbar.TabIndex = 9;
            this.trackbar.Value = 10;
            this.trackbar.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            // 
            // btnyasrengi
            // 
            this.btnyasrengi.Location = new System.Drawing.Point(267, 118);
            this.btnyasrengi.Name = "btnyasrengi";
            this.btnyasrengi.Size = new System.Drawing.Size(75, 44);
            this.btnyasrengi.TabIndex = 10;
            this.btnyasrengi.Text = "yaşınızın rengi";
            this.btnyasrengi.UseVisualStyleBackColor = true;
            this.btnyasrengi.Click += new System.EventHandler(this.btnyasrengi_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 304);
            this.Controls.Add(this.btnyasrengi);
            this.Controls.Add(this.trackbar);
            this.Controls.Add(this.dtpdtarihi);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.btnyasgitsin);
            this.Controls.Add(this.btnyasgelsin);
            this.Controls.Add(this.btnyashesapla);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnyashesapla;
        private System.Windows.Forms.Button btnyasgelsin;
        private System.Windows.Forms.Button btnyasgitsin;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.DateTimePicker dtpdtarihi;
        private System.Windows.Forms.TrackBar trackbar;
        private System.Windows.Forms.Button btnyasrengi;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}