using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using EczaDepoOtomasyonu.VeriErisim;

namespace EczaDepoOtomasyonu.Forms
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = SqlBaglanti.BaglantiGetir();
            string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmAnaSayfa anaSayfa = new FrmAnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            oku.Close();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Forms.FrmKayit kayitFormu = new Forms.FrmKayit();
            kayitFormu.Show();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}