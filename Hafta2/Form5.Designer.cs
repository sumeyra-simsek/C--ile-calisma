namespace Hafta2
{
    partial class Form5
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbadet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbadet = new System.Windows.Forms.TextBox();
            this.tbort = new System.Windows.Forms.TextBox();
            this.btnveri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lbadet
            // 
            this.lbadet.AutoSize = true;
            this.lbadet.Location = new System.Drawing.Point(16, 89);
            this.lbadet.Name = "lbadet";
            this.lbadet.Size = new System.Drawing.Size(31, 13);
            this.lbadet.TabIndex = 1;
            this.lbadet.Text = "adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ortalama:";
            // 
            // tbadet
            // 
            this.tbadet.Location = new System.Drawing.Point(68, 86);
            this.tbadet.Name = "tbadet";
            this.tbadet.Size = new System.Drawing.Size(100, 20);
            this.tbadet.TabIndex = 3;
            // 
            // tbort
            // 
            this.tbort.Location = new System.Drawing.Point(68, 117);
            this.tbort.Name = "tbort";
            this.tbort.Size = new System.Drawing.Size(100, 20);
            this.tbort.TabIndex = 4;
            // 
            // btnveri
            // 
            this.btnveri.Location = new System.Drawing.Point(189, 89);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(83, 41);
            this.btnveri.TabIndex = 5;
            this.btnveri.Text = "veri girişine başla";
            this.btnveri.UseVisualStyleBackColor = true;
            this.btnveri.Click += new System.EventHandler(this.btnveri_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.btnveri);
            this.Controls.Add(this.tbort);
            this.Controls.Add(this.tbadet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbadet);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbadet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbadet;
        private System.Windows.Forms.TextBox tbort;
        private System.Windows.Forms.Button btnveri;
    }
}