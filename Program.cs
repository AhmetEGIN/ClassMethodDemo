using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyadi = "EGİN";
            musteri1.Id = 1;
            musteri1.TcNo = "98765432134";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Engin";
            musteri2.Soyadi = "DEMİROĞ";
            musteri2.Id = 2;
            musteri2.TcNo = "12345678902";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Adı: {0} Soyadı: {1} Id No: {2}", musteri.Ad, musteri.Soyadi,musteri.Id);
            }
            MusteriManager.Ekle(musteri1);
            MusteriManager.Listele(musteri1);
            MusteriManager.Listele(musteri2);
            MusteriManager.Sil(musteri1);
            
        }
    }
}
