using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = "123456";
            musteri1.MusteriAdi = "Samet";
            musteri1.MusteriSoyadi = "Cihangir";
            musteri1.MusteriHesapNo = "987654321";
            musteri1.MusteriBakiyeMiktari = "2000";

            Musteri musteri2 = new Musteri();
            musteri2.ID = "654321";
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Kılıç";
            musteri2.MusteriHesapNo = "8549854321";
            musteri2.MusteriBakiyeMiktari = "2000";

            Musteri musteri3 = new Musteri();
            musteri3.ID = "231654";
            musteri3.MusteriAdi = "Cem";
            musteri3.MusteriSoyadi = "Öztürk";
            musteri3.MusteriHesapNo = "654987321";
            musteri3.MusteriBakiyeMiktari = "2000";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
                Console.WriteLine(musteri.ID + " " + musteri.MusteriBakiyeMiktari);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSilme(musteri1);

            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriSilme(musteri2);

            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListele(musteri3);
            musteriManager.MusteriSilme(musteri3);


        }
    }
}
