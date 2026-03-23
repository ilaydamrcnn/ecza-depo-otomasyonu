using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using EczaDepoOtomasyonu.VeriErisim;

namespace EczaDepoOtomasyonu.Forms
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKayitKullanici.Text == "" || txtKayitSifre.Text == "" || cmbRol.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiGetir();

                string sorgu = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Rol) VALUES (@p1, @p2, @p3)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtKayitKullanici.Text);
                komut.Parameters.AddWithValue("@p2", txtKayitSifre.Text);
                komut.Parameters.AddWithValue("@p3", cmbRol.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}