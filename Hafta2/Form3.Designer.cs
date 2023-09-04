namespace Hafta2
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbkactane = new System.Windows.Forms.TextBox();
            this.lbkactane = new System.Windows.Forms.Label();
            this.btnsay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 36);
            this.progressBar1.TabIndex = 0;
            // 
            // tbkactane
            // 
            this.tbkactane.Location = new System.Drawing.Point(268, 131);
            this.tbkactane.Name = "tbkactane";
            this.tbkactane.Size = new System.Drawing.Size(100, 20);
            this.tbkactane.TabIndex = 1;
            // 
            // lbkactane
            // 
            this.lbkactane.AutoSize = true;
            this.lbkactane.Location = new System.Drawing.Point(202, 134);
            this.lbkactane.Name = "lbkactane";
            this.lbkactane.Size = new System.Drawing.Size(49, 13);
            this.lbkactane.TabIndex = 2;
            this.lbkactane.Text = "kaç tane";
            // 
            // btnsay
            // 
            this.btnsay.Location = new System.Drawing.Point(257, 184);
            this.btnsay.Name = "btnsay";
            this.btnsay.Size = new System.Drawing.Size(75, 23);
            this.btnsay.TabIndex = 3;
            this.btnsay.Text = "say";
            this.btnsay.UseVisualStyleBackColor = true;
            this.btnsay.Click += new System.EventHandler(this.btnsay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(40, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsay);
            this.Controls.Add(this.lbkactane);
            this.Controls.Add(this.tbkactane);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbkactane;
        private System.Windows.Forms.Label lbkactane;
        private System.Windows.Forms.Button btnsay;
        private System.Windows.Forms.Label label1;
    }
}