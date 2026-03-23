namespace EczaDepoOtomasyonu.Forms
{
    partial class FrmGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStok = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStok)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStok
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStok.ChartAreas.Add(chartArea1);
            this.chartStok.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStok.Legends.Add(legend1);
            this.chartStok.Location = new System.Drawing.Point(0, 0);
            this.chartStok.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chartStok.Name = "chartStok";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStok.Series.Add(series1);
            this.chartStok.Size = new System.Drawing.Size(1009, 734);
            this.chartStok.TabIndex = 0;
            this.chartStok.Text = "chart1";
            // 
            // FrmGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 734);
            this.Controls.Add(this.chartStok);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmGrafik";
            this.Text = "FrmGrafik";
            this.Load += new System.EventHandler(this.FrmGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStok;
    }
}