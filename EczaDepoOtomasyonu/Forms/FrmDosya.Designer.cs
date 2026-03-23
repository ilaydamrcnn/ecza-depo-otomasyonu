namespace EczaDepoOtomasyonu.Forms
{
    partial class FrmDosya
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.lstVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(209, 82);
            this.btnYaz.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(439, 91);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "İlaç Listesini Dosyaya Yaz (Yedekle)";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(209, 206);
            this.btnOku.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(439, 78);
            this.btnOku.TabIndex = 1;
            this.btnOku.Text = "Dosyadan Oku ve Göster";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // lstVeriler
            // 
            this.lstVeriler.FormattingEnabled = true;
            this.lstVeriler.ItemHeight = 23;
            this.lstVeriler.Location = new System.Drawing.Point(14, 367);
            this.lstVeriler.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lstVeriler.Name = "lstVeriler";
            this.lstVeriler.Size = new System.Drawing.Size(859, 257);
            this.lstVeriler.TabIndex = 2;
            // 
            // FrmDosya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.lstVeriler);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnYaz);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmDosya";
            this.Text = "FrmDosya";
            this.Load += new System.EventHandler(this.FrmDosya_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.ListBox lstVeriler;
    }
}