using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EczaDepoOtomasyonu.VeriErisim;

namespace EczaDepoOtomasyonu.Forms
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            // --- 1. GENEL GÖRÜNÜM AYARLARI ---
            chartStok.BackColor = Color.WhiteSmoke;
            chartStok.ChartAreas[0].BackColor = Color.AliceBlue;

            chartStok.Titles.Clear();
            Title baslik = chartStok.Titles.Add("Güncel İlaç Stok Durumu");
            baslik.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            baslik.ForeColor = Color.DarkSlateGray;

            // 3D Görünüm Efekti (Derinlik katar)
            chartStok.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartStok.ChartAreas[0].Area3DStyle.Inclination = 20; // Eğim açısı
            chartStok.ChartAreas[0].Area3DStyle.Rotation = 10;    // Döndürme açısı
            chartStok.Palette = ChartColorPalette.SeaGreen;

            // Izgara Çizgilerini Yumuşatma
            chartStok.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartStok.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash; // Kesik çizgi
            chartStok.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartStok.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // --- 2. SERİ VE VERİ AYARLARI ---
            chartStok.Series.Clear();
            Series seri = chartStok.Series.Add("Stoklar");
            seri.ChartType = SeriesChartType.Column; // Sütun grafik
            seri.IsValueShownAsLabel = true;
            seri.Font = new Font("Segoe UI", 10, FontStyle.Bold); 
            seri.LabelForeColor = Color.DarkSlateGray;
            seri["PixelPointWidth"] = "50";

            // 3. VERİTABANINDAN VERİ ÇEKME
            try
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiGetir();
                SqlCommand komut = new SqlCommand("SELECT Ad, StokAdedi FROM Ilaclar ORDER BY StokAdedi DESC", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    DataPoint nokta = new DataPoint();
                    nokta.AxisLabel = oku["Ad"].ToString(); // X eksenindeki isim
                    nokta.YValues = new double[] { Convert.ToDouble(oku["StokAdedi"]) }; // Y değeri
                    seri.Points.Add(nokta);
                }
                oku.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grafik yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}