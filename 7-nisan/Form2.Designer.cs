namespace _7_nisan
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
            this.nudkactane = new System.Windows.Forms.NumericUpDown();
            this.nudnereden = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbyazi = new System.Windows.Forms.TextBox();
            this.tbtersten = new System.Windows.Forms.TextBox();
            this.btntersyaz = new System.Windows.Forms.Button();
            this.btnkelimeler = new System.Windows.Forms.Button();
            this.btnalgstr = new System.Windows.Forms.Button();
            this.labelnereden = new System.Windows.Forms.Label();
            this.labelkactane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudkactane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnereden)).BeginInit();
            this.SuspendLayout();
            // 
            // nudkactane
            // 
            this.nudkactane.Location = new System.Drawing.Point(393, 182);
            this.nudkactane.Name = "nudkactane";
            this.nudkactane.Size = new System.Drawing.Size(47, 20);
            this.nudkactane.TabIndex = 0;
            // 
            // nudnereden
            // 
            this.nudnereden.Location = new System.Drawing.Point(287, 182);
            this.nudnereden.Name = "nudnereden";
            this.nudnereden.Size = new System.Drawing.Size(58, 20);
            this.nudnereden.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(287, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 108);
            this.listBox1.TabIndex = 2;
            // 
            // tbyazi
            // 
            this.tbyazi.Location = new System.Drawing.Point(24, 52);
            this.tbyazi.Name = "tbyazi";
            this.tbyazi.Size = new System.Drawing.Size(224, 20);
            this.tbyazi.TabIndex = 3;
            this.tbyazi.Text = "Bilgisayar müh";
            // 
            // tbtersten
            // 
            this.tbtersten.Location = new System.Drawing.Point(24, 88);
            this.tbtersten.Name = "tbtersten";
            this.tbtersten.Size = new System.Drawing.Size(224, 20);
            this.tbtersten.TabIndex = 4;
            // 
            // btntersyaz
            // 
            this.btntersyaz.Location = new System.Drawing.Point(24, 165);
            this.btntersyaz.Name = "btntersyaz";
            this.btntersyaz.Size = new System.Drawing.Size(75, 51);
            this.btntersyaz.TabIndex = 5;
            this.btntersyaz.Text = "Tersten yazdır";
            this.btntersyaz.UseVisualStyleBackColor = true;
            this.btntersyaz.Click += new System.EventHandler(this.btntersyaz_Click);
            // 
            // btnkelimeler
            // 
            this.btnkelimeler.Location = new System.Drawing.Point(118, 166);
            this.btnkelimeler.Name = "btnkelimeler";
            this.btnkelimeler.Size = new System.Drawing.Size(75, 50);
            this.btnkelimeler.TabIndex = 6;
            this.btnkelimeler.Text = "button2";
            this.btnkelimeler.UseVisualStyleBackColor = true;
            this.btnkelimeler.Click += new System.EventHandler(this.btnkelimeler_Click);
            // 
            // btnalgstr
            // 
            this.btnalgstr.Location = new System.Drawing.Point(332, 222);
            this.btnalgstr.Name = "btnalgstr";
            this.btnalgstr.Size = new System.Drawing.Size(75, 23);
            this.btnalgstr.TabIndex = 7;
            this.btnalgstr.Text = "Al-Göster";
            this.btnalgstr.UseVisualStyleBackColor = true;
            this.btnalgstr.Click += new System.EventHandler(this.btnalgstr_Click);
            // 
            // labelnereden
            // 
            this.labelnereden.AutoSize = true;
            this.labelnereden.Location = new System.Drawing.Point(284, 166);
            this.labelnereden.Name = "labelnereden";
            this.labelnereden.Size = new System.Drawing.Size(88, 13);
            this.labelnereden.TabIndex = 8;
            this.labelnereden.Text = "Nereden itibaren:";
            // 
            // labelkactane
            // 
            this.labelkactane.AutoSize = true;
            this.labelkactane.Location = new System.Drawing.Point(390, 166);
            this.labelkactane.Name = "labelkactane";
            this.labelkactane.Size = new System.Drawing.Size(50, 13);
            this.labelkactane.TabIndex = 9;
            this.labelkactane.Text = "Kaç tane";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.labelkactane);
            this.Controls.Add(this.labelnereden);
            this.Controls.Add(this.btnalgstr);
            this.Controls.Add(this.btnkelimeler);
            this.Controls.Add(this.btntersyaz);
            this.Controls.Add(this.tbtersten);
            this.Controls.Add(this.tbyazi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nudnereden);
            this.Controls.Add(this.nudkactane);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudkactane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnereden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudkactane;
        private System.Windows.Forms.NumericUpDown nudnereden;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbyazi;
        private System.Windows.Forms.TextBox tbtersten;
        private System.Windows.Forms.Button btntersyaz;
        private System.Windows.Forms.Button btnkelimeler;
        private System.Windows.Forms.Button btnalgstr;
        private System.Windows.Forms.Label labelnereden;
        private System.Windows.Forms.Label labelkactane;
    }
}