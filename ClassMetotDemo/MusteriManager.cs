using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi"+ musteri.Ad +" "+ musteri.Soyad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi" + musteri.Ad + " "+musteri.Soyad);
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad:" + musteri.Ad);
                Console.WriteLine("Soyad:" + musteri.Soyad);
                Console.WriteLine("---");
            }
        }
    }
}