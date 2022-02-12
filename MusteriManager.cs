using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public static void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın {0} {1} bankamızı tercih ettiğiniz için teşekkür ederiz. Id numaranız: {2}",musteri.Ad,musteri.Soyadi,musteri.Id);
        }
        public static void Listele(Musteri musteri)
        {
            Console.WriteLine("{0} TC kimlik numaralı {1} {2} kişisinin Id numarası: {3}", musteri.TcNo, musteri.Ad, musteri.Soyadi, musteri.Id);
        }
        public static void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} id numaralı kişi listeden çıkarılmıştır. Sayın {1} {2} sizi tekrardan aramızda görmek isteriz.", musteri.Id, musteri.Ad, musteri.Soyadi);
        }

    }
}
