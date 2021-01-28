using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);

        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi: " + musteri.ID + " " + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriBakiyeMiktari);

        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);

        }
    }
}