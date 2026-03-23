namespace EczaDepoOtomasyonu.Forms
{
    partial class FrmAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ilaçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGrafiğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçİşlemleriToolStripMenuItem,
            this.grafiklerToolStripMenuItem,
            this.dosyaİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1554, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ilaçİşlemleriToolStripMenuItem
            // 
            this.ilaçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçYönetimiToolStripMenuItem});
            this.ilaçİşlemleriToolStripMenuItem.Name = "ilaçİşlemleriToolStripMenuItem";
            this.ilaçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.ilaçİşlemleriToolStripMenuItem.Text = "İlaç İşlemleri";
            // 
            // ilaçYönetimiToolStripMenuItem
            // 
            this.ilaçYönetimiToolStripMenuItem.Name = "ilaçYönetimiToolStripMenuItem";
            this.ilaçYönetimiToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.ilaçYönetimiToolStripMenuItem.Text = "İlaç Yönetimi";
            this.ilaçYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ilaçYönetimiToolStripMenuItem_Click);
            // 
            // grafiklerToolStripMenuItem
            // 
            this.grafiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGrafiğiToolStripMenuItem});
            this.grafiklerToolStripMenuItem.Name = "grafiklerToolStripMenuItem";
            this.grafiklerToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.grafiklerToolStripMenuItem.Text = "Grafikler";
            // 
            // stokGrafiğiToolStripMenuItem
            // 
            this.stokGrafiğiToolStripMenuItem.Name = "stokGrafiğiToolStripMenuItem";
            this.stokGrafiğiToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.stokGrafiğiToolStripMenuItem.Text = "Stok Grafiği";
            this.stokGrafiğiToolStripMenuItem.Click += new System.EventHandler(this.stokGrafiğiToolStripMenuItem_Click);
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yedeklemeEkranıToolStripMenuItem});
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            this.dosyaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.dosyaİşlemleriToolStripMenuItem.Text = "Yedekleme İşlemleri";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // yedeklemeEkranıToolStripMenuItem
            // 
            this.yedeklemeEkranıToolStripMenuItem.Name = "yedeklemeEkranıToolStripMenuItem";
            this.yedeklemeEkranıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yedeklemeEkranıToolStripMenuItem.Text = "Yedekleme Ekranı";
            this.yedeklemeEkranıToolStripMenuItem.Click += new System.EventHandler(this.yedeklemeEkranıToolStripMenuItem_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1554, 797);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eczane Stok Takip Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ilaçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGrafiğiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedeklemeEkranıToolStripMenuItem;
    }
}