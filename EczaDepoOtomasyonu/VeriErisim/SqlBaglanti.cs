using System.Data.SqlClient;

namespace EczaDepoOtomasyonu.VeriErisim 
{
    public class SqlBaglanti
    {
        private static string adres = @"Data Source=DESKTOP-GQ9D3S3\SQLEXPRESS;Initial Catalog=EczaneDB;Integrated Security=True";

        public static SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(adres);

            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }
    }
}