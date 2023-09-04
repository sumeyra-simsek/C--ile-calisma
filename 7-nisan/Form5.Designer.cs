namespace _7_nisan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbaranan = new System.Windows.Forms.TextBox();
            this.lbaranacakdeger = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnartan = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.rbherikisi = new System.Windows.Forms.RadioButton();
            this.rbcombobox = new System.Windows.Forms.RadioButton();
            this.rblistbox = new System.Windows.Forms.RadioButton();
            this.tbeklenecekisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbaranan);
            this.groupBox1.Controls.Add(this.lbaranacakdeger);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama işlemi";
            // 
            // tbaranan
            // 
            this.tbaranan.Location = new System.Drawing.Point(113, 24);
            this.tbaranan.Name = "tbaranan";
            this.tbaranan.Size = new System.Drawing.Size(190, 20);
            this.tbaranan.TabIndex = 1;
            this.tbaranan.TextChanged += new System.EventHandler(this.tbaranan_TextChanged);
            // 
            // lbaranacakdeger
            // 
            this.lbaranacakdeger.AutoSize = true;
            this.lbaranacakdeger.Location = new System.Drawing.Point(24, 27);
            this.lbaranacakdeger.Name = "lbaranacakdeger";
            this.lbaranacakdeger.Size = new System.Drawing.Size(83, 13);
            this.lbaranacakdeger.TabIndex = 0;
            this.lbaranacakdeger.Text = "Aranacak değer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 225);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "limon",
            "kavun",
            "karpuz",
            "muz"});
            this.comboBox1.Location = new System.Drawing.Point(185, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnartan);
            this.groupBox3.Controls.Add(this.btnekle);
            this.groupBox3.Controls.Add(this.rbherikisi);
            this.groupBox3.Controls.Add(this.rbcombobox);
            this.groupBox3.Controls.Add(this.rblistbox);
            this.groupBox3.Controls.Add(this.tbeklenecekisim);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(185, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 197);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekleme seçenekleri";
            // 
            // btnartan
            // 
            this.btnartan.Location = new System.Drawing.Point(122, 155);
            this.btnartan.Name = "btnartan";
            this.btnartan.Size = new System.Drawing.Size(75, 36);
            this.btnartan.TabIndex = 6;
            this.btnartan.Text = "Artan sıralama";
            this.btnartan.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(28, 155);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // rbherikisi
            // 
            this.rbherikisi.AutoSize = true;
            this.rbherikisi.Location = new System.Drawing.Point(73, 113);
            this.rbherikisi.Name = "rbherikisi";
            this.rbherikisi.Size = new System.Drawing.Size(89, 17);
            this.rbherikisi.TabIndex = 4;
            this.rbherikisi.TabStop = true;
            this.rbherikisi.Text = "Her ikisine de";
            this.rbherikisi.UseVisualStyleBackColor = true;
            // 
            // rbcombobox
            // 
            this.rbcombobox.AutoSize = true;
            this.rbcombobox.Location = new System.Drawing.Point(135, 90);
            this.rbcombobox.Name = "rbcombobox";
            this.rbcombobox.Size = new System.Drawing.Size(86, 17);
            this.rbcombobox.TabIndex = 3;
            this.rbcombobox.TabStop = true;
            this.rbcombobox.Text = "Combo box\'a";
            this.rbcombobox.UseVisualStyleBackColor = true;
            // 
            // rblistbox
            // 
            this.rblistbox.AutoSize = true;
            this.rblistbox.Location = new System.Drawing.Point(18, 90);
            this.rblistbox.Name = "rblistbox";
            this.rblistbox.Size = new System.Drawing.Size(69, 17);
            this.rblistbox.TabIndex = 2;
            this.rblistbox.TabStop = true;
            this.rblistbox.Text = "List box\'a";
            this.rblistbox.UseVisualStyleBackColor = true;
            // 
            // tbeklenecekisim
            // 
            this.tbeklenecekisim.Location = new System.Drawing.Point(18, 54);
            this.tbeklenecekisim.Name = "tbeklenecekisim";
            this.tbeklenecekisim.Size = new System.Drawing.Size(189, 20);
            this.tbeklenecekisim.TabIndex = 1;
            this.tbeklenecekisim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbeklenecekisim_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eklenecek ismi girin enter tuşuna basın :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 368);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(454, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 393);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbaranan;
        private System.Windows.Forms.Label lbaranacakdeger;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnartan;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.RadioButton rbherikisi;
        private System.Windows.Forms.RadioButton rbcombobox;
        private System.Windows.Forms.RadioButton rblistbox;
        private System.Windows.Forms.TextBox tbeklenecekisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}