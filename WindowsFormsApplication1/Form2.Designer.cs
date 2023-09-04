namespace WindowsFormsApplication1
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
            this.btntıklasay = new System.Windows.Forms.Button();
            this.btnsay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntıklasay
            // 
            this.btntıklasay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btntıklasay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntıklasay.ForeColor = System.Drawing.SystemColors.Control;
            this.btntıklasay.Location = new System.Drawing.Point(90, 182);
            this.btntıklasay.Name = "btntıklasay";
            this.btntıklasay.Size = new System.Drawing.Size(94, 38);
            this.btntıklasay.TabIndex = 0;
            this.btntıklasay.Text = "tıkla-say";
            this.btntıklasay.UseVisualStyleBackColor = false;
            this.btntıklasay.Click += new System.EventHandler(this.btntıklasay_Click);
            this.btntıklasay.MouseEnter += new System.EventHandler(this.btntıklasay_MouseEnter);
            this.btntıklasay.MouseLeave += new System.EventHandler(this.btntıklasay_MouseLeave);
            // 
            // btnsay
            // 
            this.btnsay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsay.Location = new System.Drawing.Point(90, 125);
            this.btnsay.Name = "btnsay";
            this.btnsay.Size = new System.Drawing.Size(94, 31);
            this.btnsay.TabIndex = 1;
            this.btnsay.Text = "say";
            this.btnsay.UseVisualStyleBackColor = false;
            this.btnsay.Click += new System.EventHandler(this.btnsay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsay);
            this.Controls.Add(this.btntıklasay);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntıklasay;
        private System.Windows.Forms.Button btnsay;
        private System.Windows.Forms.Label label1;
    }
}