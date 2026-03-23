using System;

namespace EczaDepoOtomasyonu.Entities
{
    public class Ilac
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; } // Şurup, Hap vs.
        public int StokAdedi { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }

        // Bu özellik, ileride ListBox veya ComboBox'ta ilacın adını göstermek için işimize yarayacak
        public override string ToString()
        {
            return Ad;
        }
    }
}