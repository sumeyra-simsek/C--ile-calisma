namespace Hafta2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dersler = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secilendersler = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnekle = new System.Windows.Forms.Button();
            this.btncokluders = new System.Windows.Forms.Button();
            this.btncıkar = new System.Windows.Forms.Button();
            this.tbYenıders = new System.Windows.Forms.TextBox();
            this.cbyeniders = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secımıIptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dersler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dersler";
            // 
            // Dersler
            // 
            this.Dersler.ContextMenuStrip = this.contextMenuStrip1;
            this.Dersler.FormattingEnabled = true;
            this.Dersler.Items.AddRange(new object[] {
            "Nesneye yönelik programlama",
            "işletim sistemleri "});
            this.Dersler.Location = new System.Drawing.Point(6, 19);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(174, 199);
            this.Dersler.TabIndex = 0;
            this.Dersler.DoubleClick += new System.EventHandler(this.btnekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secilendersler);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "secilen dersler";
            // 
            // secilendersler
            // 
            this.secilendersler.FormattingEnabled = true;
            this.secilendersler.Location = new System.Drawing.Point(6, 19);
            this.secilendersler.Name = "secilendersler";
            this.secilendersler.Size = new System.Drawing.Size(176, 199);
            this.secilendersler.TabIndex = 0;
            this.secilendersler.DoubleClick += new System.EventHandler(this.btncıkar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(218, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(145, 223);
            this.progressBar1.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(18, 250);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(104, 23);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ders ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btncokluders
            // 
            this.btncokluders.Location = new System.Drawing.Point(18, 279);
            this.btncokluders.Name = "btncokluders";
            this.btncokluders.Size = new System.Drawing.Size(104, 23);
            this.btncokluders.TabIndex = 4;
            this.btncokluders.Text = "çoklu ders ekle";
            this.btncokluders.UseVisualStyleBackColor = true;
            this.btncokluders.Click += new System.EventHandler(this.btncokluders_Click);
            // 
            // btncıkar
            // 
            this.btncıkar.Location = new System.Drawing.Point(18, 308);
            this.btncıkar.Name = "btncıkar";
            this.btncıkar.Size = new System.Drawing.Size(104, 23);
            this.btncıkar.TabIndex = 5;
            this.btncıkar.Text = "Çıkar";
            this.btncıkar.UseVisualStyleBackColor = true;
            this.btncıkar.Click += new System.EventHandler(this.btncıkar_Click);
            // 
            // tbYenıders
            // 
            this.tbYenıders.Location = new System.Drawing.Point(162, 293);
            this.tbYenıders.Name = "tbYenıders";
            this.tbYenıders.Size = new System.Drawing.Size(296, 20);
            this.tbYenıders.TabIndex = 7;
            this.tbYenıders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbYenıders_KeyDown);
            // 
            // cbyeniders
            // 
            this.cbyeniders.AutoSize = true;
            this.cbyeniders.Location = new System.Drawing.Point(162, 256);
            this.cbyeniders.Name = "cbyeniders";
            this.cbyeniders.Size = new System.Drawing.Size(91, 17);
            this.cbyeniders.TabIndex = 8;
            this.cbyeniders.Text = "yeni ders ekle";
            this.cbyeniders.UseVisualStyleBackColor = true;
            this.cbyeniders.Click += new System.EventHandler(this.cbyeniders_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.secımıIptalEtToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ekleToolStripMenuItem.Text = "ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // secımıIptalEtToolStripMenuItem
            // 
            this.secımıIptalEtToolStripMenuItem.Name = "secımıIptalEtToolStripMenuItem";
            this.secımıIptalEtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.secımıIptalEtToolStripMenuItem.Text = "secımı ıptal et";
            this.secımıIptalEtToolStripMenuItem.Click += new System.EventHandler(this.secımıIptalEtToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.çıkışToolStripMenuItem.Text = "çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 335);
            this.Controls.Add(this.cbyeniders);
            this.Controls.Add(this.tbYenıders);
            this.Controls.Add(this.btncıkar);
            this.Controls.Add(this.btncokluders);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Dersler;
        private System.Windows.Forms.ListBox secilendersler;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btncokluders;
        private System.Windows.Forms.Button btncıkar;
        private System.Windows.Forms.TextBox tbYenıders;
        private System.Windows.Forms.CheckBox cbyeniders;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secımıIptalEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}