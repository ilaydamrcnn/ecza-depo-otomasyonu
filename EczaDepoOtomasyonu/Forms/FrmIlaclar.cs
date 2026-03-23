using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EczaDepoOtomasyonu.VeriErisim;

namespace EczaDepoOtomasyonu.Forms
{
    public partial class FrmIlaclar : Form
    {
        public FrmIlaclar()
        {
            InitializeComponent();
        }
 
        public delegate void StokHandler();

        public event StokHandler StokAzaldi;
       
        void StokUyariVer()
        {
            MessageBox.Show("DİKKAT! Bu ürünün stoğu kritik seviyenin altına düştü!", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        int secilenId = 0;
        void Listele()
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiGetir();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ilaclar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gridIlaclar.DataSource = dt;
        }

        private void FrmIlaclar_Load(object sender, EventArgs e)
        {
           
            StokAzaldi += new StokHandler(StokUyariVer);
           
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiGetir();
                string sorgu = "INSERT INTO Ilaclar (BarkodNo, Ad, Tur, StokAdedi, Fiyat, SonKullanmaTarihi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", cmbTur.Text);
                komut.Parameters.AddWithValue("@p4", int.Parse(txtStok.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p6", dtpTarih.Value);

                komut.ExecuteNonQuery();
                int girilenStok = int.Parse(txtStok.Text);
                if (girilenStok < 20)
                {
                    StokAzaldi?.Invoke();
                }

                MessageBox.Show("İlaç başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message + "\nLütfen stok ve fiyat kısmına sayı giriniz.");
            }
        }

        private void gridIlaclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = gridIlaclar.Rows[e.RowIndex];

                // ID'yi hafızaya aldım güncelleme için
                secilenId = int.Parse(satir.Cells["Id"].Value.ToString());

                
                txtBarkod.Text = satir.Cells["BarkodNo"].Value.ToString();
                txtAd.Text = satir.Cells["Ad"].Value.ToString();
                cmbTur.Text = satir.Cells["Tur"].Value.ToString();
                txtStok.Text = satir.Cells["StokAdedi"].Value.ToString();
                txtFiyat.Text = satir.Cells["Fiyat"].Value.ToString();

                try
                {
                    var tarihVerisi = satir.Cells["SonKullanmaTarihi"].Value;
                    if (tarihVerisi != null && tarihVerisi.ToString() != "")
                    {
                        dtpTarih.Value = DateTime.Parse(tarihVerisi.ToString());
                    }
                    else
                    {
                        dtpTarih.Value = DateTime.Now;
                    }
                }
                catch (Exception)
                {
                    dtpTarih.Value = DateTime.Now;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen silinecek ilacı listeden seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show("Bu ilacı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiGetir();
                SqlCommand komut = new SqlCommand("DELETE FROM Ilaclar WHERE Id=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", secilenId);

                komut.ExecuteNonQuery();

                MessageBox.Show("İlaç silindi.");
                Listele();    
                Temizle();    
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek ilacı seçiniz.");
                return;
            }

            try
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiGetir();
                string sorgu = "UPDATE Ilaclar SET BarkodNo=@p1, Ad=@p2, Tur=@p3, StokAdedi=@p4, Fiyat=@p5, SonKullanmaTarihi=@p6 WHERE Id=@p7";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", cmbTur.Text);
                komut.Parameters.AddWithValue("@p4", int.Parse(txtStok.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p6", dtpTarih.Value);
                komut.Parameters.AddWithValue("@p7", secilenId); // Hangi kaydı güncelleyeceğimizi belirtiyoruz

                komut.ExecuteNonQuery();
                // Stok kontrolü
                int girilenStok = int.Parse(txtStok.Text);
                if (girilenStok < 20)
                {
                    StokAzaldi?.Invoke();
                }

                MessageBox.Show("İlaç bilgileri güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        void Temizle()
        {
            txtBarkod.Text = "";
            txtAd.Text = "";
            cmbTur.Text = "";
            txtStok.Text = "";
            txtFiyat.Text = "";
            secilenId = 0;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}