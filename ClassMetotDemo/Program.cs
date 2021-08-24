using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "XZ";
            musteri1.Soyad = "Corp";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Zee";
            musteri2.Soyad = "body";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
           
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);

            Console.ReadLine();
        }
    }
}
