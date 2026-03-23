using System;
using System.Data.SqlClient;
using System.IO; // <--- BU ÇOK ÖNEMLİ, DOSYA İŞLEMLERİ İÇİN
using System.Windows.Forms;
using EczaDepoOtomasyonu.VeriErisim;

namespace EczaDepoOtomasyonu.Forms
{
    public partial class FrmDosya : Form
    {
        public FrmDosya()
        {
            InitializeComponent();
        }

        private void FrmDosya_Load(object sender, EventArgs e)
        {

        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = SqlBaglanti.BaglantiGetir();
                SqlCommand komut = new SqlCommand("SELECT * FROM Ilaclar", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                StreamWriter yazici = new StreamWriter("IlacYedek.txt");

                yazici.WriteLine("--- İLAÇ STOK LİSTESİ ---");
                yazici.WriteLine("Tarih: " + DateTime.Now.ToString());
                yazici.WriteLine("-------------------------");

                while (oku.Read())
                {
                    string satir = $"İlaç: {oku["Ad"]} - Stok: {oku["StokAdedi"]} - Fiyat: {oku["Fiyat"]}";
                    yazici.WriteLine(satir); 
                }

                yazici.Close();
                oku.Close();

                MessageBox.Show("Dosya başarıyla oluşturuldu: IlacYedek.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            try
            {
                lstVeriler.Items.Clear(); 

                if (File.Exists("IlacYedek.txt")) 
                {
                    StreamReader okuyucu = new StreamReader("IlacYedek.txt");

                    string okunanSatir;
                    while ((okunanSatir = okuyucu.ReadLine()) != null)
                    {
                        lstVeriler.Items.Add(okunanSatir); 
                    }

                    okuyucu.Close();
                }
                else
                {
                    MessageBox.Show("Henüz bir yedek dosyası oluşturulmamış! Önce 'Yaz' butonuna basınız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
