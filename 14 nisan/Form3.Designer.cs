namespace _14_nisan
{
    partial class Form3
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
            this.lbka = new System.Windows.Forms.Label();
            this.lbsf = new System.Windows.Forms.Label();
            this.tbka = new System.Windows.Forms.TextBox();
            this.tbsf = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbka
            // 
            this.lbka.AutoSize = true;
            this.lbka.Location = new System.Drawing.Point(55, 48);
            this.lbka.Name = "lbka";
            this.lbka.Size = new System.Drawing.Size(68, 13);
            this.lbka.TabIndex = 0;
            this.lbka.Text = "kullanıcı adı :";
            // 
            // lbsf
            // 
            this.lbsf.AutoSize = true;
            this.lbsf.Location = new System.Drawing.Point(58, 77);
            this.lbsf.Name = "lbsf";
            this.lbsf.Size = new System.Drawing.Size(35, 13);
            this.lbsf.TabIndex = 1;
            this.lbsf.Text = "şifre : ";
            // 
            // tbka
            // 
            this.tbka.Location = new System.Drawing.Point(135, 48);
            this.tbka.Name = "tbka";
            this.tbka.Size = new System.Drawing.Size(100, 20);
            this.tbka.TabIndex = 2;
            // 
            // tbsf
            // 
            this.tbsf.Location = new System.Drawing.Point(135, 77);
            this.tbsf.Name = "tbsf";
            this.tbsf.Size = new System.Drawing.Size(100, 20);
            this.tbsf.TabIndex = 3;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(95, 126);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 23);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "üye giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.tbsf);
            this.Controls.Add(this.tbka);
            this.Controls.Add(this.lbsf);
            this.Controls.Add(this.lbka);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbka;
        private System.Windows.Forms.Label lbsf;
        private System.Windows.Forms.TextBox tbka;
        private System.Windows.Forms.TextBox tbsf;
        private System.Windows.Forms.Button btngiris;
    }
}