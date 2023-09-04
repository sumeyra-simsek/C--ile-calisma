namespace _21_nisan
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbbolumtanimlari = new System.Windows.Forms.GroupBox();
            this.tbbolumadi = new System.Windows.Forms.TextBox();
            this.tbbolumkodu = new System.Windows.Forms.TextBox();
            this.lbbolumadi = new System.Windows.Forms.Label();
            this.lbbolumkodu = new System.Windows.Forms.Label();
            this.gbislemler = new System.Windows.Forms.GroupBox();
            this.btnraporla = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.gbkayit = new System.Windows.Forms.GroupBox();
            this.tbaranan = new System.Windows.Forms.TextBox();
            this.lbbolumadi2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbbolumtanimlari.SuspendLayout();
            this.gbislemler.SuspendLayout();
            this.gbkayit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(9, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bolumkodu";
            this.Column1.HeaderText = "Bölüm kodu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "bolumad";
            this.Column2.HeaderText = "Bölüm adı";
            this.Column2.Name = "Column2";
            // 
            // gbbolumtanimlari
            // 
            this.gbbolumtanimlari.Controls.Add(this.tbbolumadi);
            this.gbbolumtanimlari.Controls.Add(this.tbbolumkodu);
            this.gbbolumtanimlari.Controls.Add(this.lbbolumadi);
            this.gbbolumtanimlari.Controls.Add(this.lbbolumkodu);
            this.gbbolumtanimlari.Location = new System.Drawing.Point(12, 12);
            this.gbbolumtanimlari.Name = "gbbolumtanimlari";
            this.gbbolumtanimlari.Size = new System.Drawing.Size(293, 100);
            this.gbbolumtanimlari.TabIndex = 1;
            this.gbbolumtanimlari.TabStop = false;
            this.gbbolumtanimlari.Text = "Bölüm tanımları ";
            // 
            // tbbolumadi
            // 
            this.tbbolumadi.Location = new System.Drawing.Point(101, 56);
            this.tbbolumadi.Name = "tbbolumadi";
            this.tbbolumadi.Size = new System.Drawing.Size(139, 20);
            this.tbbolumadi.TabIndex = 3;
            // 
            // tbbolumkodu
            // 
            this.tbbolumkodu.Location = new System.Drawing.Point(101, 26);
            this.tbbolumkodu.Name = "tbbolumkodu";
            this.tbbolumkodu.Size = new System.Drawing.Size(139, 20);
            this.tbbolumkodu.TabIndex = 2;
            // 
            // lbbolumadi
            // 
            this.lbbolumadi.AutoSize = true;
            this.lbbolumadi.Location = new System.Drawing.Point(26, 56);
            this.lbbolumadi.Name = "lbbolumadi";
            this.lbbolumadi.Size = new System.Drawing.Size(59, 13);
            this.lbbolumadi.TabIndex = 1;
            this.lbbolumadi.Text = "Bölüm adı :";
            // 
            // lbbolumkodu
            // 
            this.lbbolumkodu.AutoSize = true;
            this.lbbolumkodu.Location = new System.Drawing.Point(26, 29);
            this.lbbolumkodu.Name = "lbbolumkodu";
            this.lbbolumkodu.Size = new System.Drawing.Size(69, 13);
            this.lbbolumkodu.TabIndex = 0;
            this.lbbolumkodu.Text = "Bölüm kodu :";
            // 
            // gbislemler
            // 
            this.gbislemler.Controls.Add(this.btnraporla);
            this.gbislemler.Controls.Add(this.btniptal);
            this.gbislemler.Controls.Add(this.btnyenikayit);
            this.gbislemler.Controls.Add(this.btnsil);
            this.gbislemler.Controls.Add(this.btnkaydet);
            this.gbislemler.Controls.Add(this.btnileri);
            this.gbislemler.Controls.Add(this.btngeri);
            this.gbislemler.Controls.Add(this.btnduzelt);
            this.gbislemler.Location = new System.Drawing.Point(12, 118);
            this.gbislemler.Name = "gbislemler";
            this.gbislemler.Size = new System.Drawing.Size(231, 158);
            this.gbislemler.TabIndex = 2;
            this.gbislemler.TabStop = false;
            this.gbislemler.Text = "işlemler";
            // 
            // btnraporla
            // 
            this.btnraporla.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnraporla.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnraporla.Location = new System.Drawing.Point(114, 79);
            this.btnraporla.Name = "btnraporla";
            this.btnraporla.Size = new System.Drawing.Size(75, 23);
            this.btnraporla.TabIndex = 4;
            this.btnraporla.Text = "Raporla";
            this.btnraporla.UseVisualStyleBackColor = false;
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btniptal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btniptal.Location = new System.Drawing.Point(17, 108);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnyenikayit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnyenikayit.Location = new System.Drawing.Point(17, 50);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(75, 23);
            this.btnyenikayit.TabIndex = 5;
            this.btnyenikayit.Text = "Yeni kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = false;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsil.Location = new System.Drawing.Point(114, 50);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkaydet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnkaydet.Location = new System.Drawing.Point(114, 108);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnileri
            // 
            this.btnileri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnileri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnileri.Location = new System.Drawing.Point(17, 79);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(75, 23);
            this.btnileri.TabIndex = 2;
            this.btnileri.Text = "İleri";
            this.btnileri.UseVisualStyleBackColor = false;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngeri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btngeri.Location = new System.Drawing.Point(114, 20);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 23);
            this.btngeri.TabIndex = 1;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnduzelt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnduzelt.Location = new System.Drawing.Point(17, 20);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(75, 23);
            this.btnduzelt.TabIndex = 0;
            this.btnduzelt.Text = "Düzelt";
            this.btnduzelt.UseVisualStyleBackColor = false;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // gbkayit
            // 
            this.gbkayit.Controls.Add(this.tbaranan);
            this.gbkayit.Controls.Add(this.lbbolumadi2);
            this.gbkayit.Controls.Add(this.dataGridView1);
            this.gbkayit.Location = new System.Drawing.Point(311, 12);
            this.gbkayit.Name = "gbkayit";
            this.gbkayit.Size = new System.Drawing.Size(266, 323);
            this.gbkayit.TabIndex = 3;
            this.gbkayit.TabStop = false;
            this.gbkayit.Text = "Kayıt arama ve listeleme";
            // 
            // tbaranan
            // 
            this.tbaranan.Location = new System.Drawing.Point(9, 53);
            this.tbaranan.Name = "tbaranan";
            this.tbaranan.Size = new System.Drawing.Size(241, 20);
            this.tbaranan.TabIndex = 2;
            this.tbaranan.TextChanged += new System.EventHandler(this.tbaranan_TextChanged);
            // 
            // lbbolumadi2
            // 
            this.lbbolumadi2.AutoSize = true;
            this.lbbolumadi2.Location = new System.Drawing.Point(6, 29);
            this.lbbolumadi2.Name = "lbbolumadi2";
            this.lbbolumadi2.Size = new System.Drawing.Size(59, 13);
            this.lbbolumadi2.TabIndex = 1;
            this.lbbolumadi2.Text = "Bölüm adı :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 339);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.duzeltToolStripMenuItem,
            this.silToolStripMenuItem,
            this.ileriToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 114);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.yeniKayıtToolStripMenuItem.Text = "yeni kayit";
            // 
            // duzeltToolStripMenuItem
            // 
            this.duzeltToolStripMenuItem.Name = "duzeltToolStripMenuItem";
            this.duzeltToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duzeltToolStripMenuItem.Text = "duzelt";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.silToolStripMenuItem.Text = "sil";
            // 
            // ileriToolStripMenuItem
            // 
            this.ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            this.ileriToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ileriToolStripMenuItem.Text = "ileri";
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.geriToolStripMenuItem.Text = "geri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 364);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbkayit);
            this.Controls.Add(this.gbislemler);
            this.Controls.Add(this.gbbolumtanimlari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbbolumtanimlari.ResumeLayout(false);
            this.gbbolumtanimlari.PerformLayout();
            this.gbislemler.ResumeLayout(false);
            this.gbkayit.ResumeLayout(false);
            this.gbkayit.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbbolumtanimlari;
        private System.Windows.Forms.TextBox tbbolumadi;
        private System.Windows.Forms.TextBox tbbolumkodu;
        private System.Windows.Forms.Label lbbolumadi;
        private System.Windows.Forms.Label lbbolumkodu;
        private System.Windows.Forms.GroupBox gbislemler;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.GroupBox gbkayit;
        private System.Windows.Forms.TextBox tbaranan;
        private System.Windows.Forms.Label lbbolumadi2;
        private System.Windows.Forms.Button btnraporla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
    }
}

