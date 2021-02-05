using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //->clasın değişkenlerini ve değerlerini oluşturma
            //değişken burası oldu
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Aleyna Yılmaz";
            musteri1.MusteriTcNo = 01111111111;
            musteri1.MusteriId = 1;
            musteri1.MusteriYas = 18;
            musteri1.MusteriKrediNot = 10;
            //buraya kadar

            //diğer değişkenleri de tanımlayalım..

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Ecrin Usta";
            musteri2.MusteriTcNo = 00222222222;
            musteri2.MusteriId = 2;
            musteri2.MusteriYas = 40;
            musteri2.MusteriKrediNot = 81;


            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Hasan Açıkgöz";
            musteri3.MusteriTcNo = 00333333333;
            musteri3.MusteriId = 3;
            musteri3.MusteriYas = 35;
            musteri3.MusteriKrediNot = 90;


            Musteri musteri4 = new Musteri();
            musteri4.MusteriAd = "Halis Aydemir";
            musteri4.MusteriTcNo = 00044444444;
            musteri4.MusteriId = 4;
            musteri4.MusteriYas = 28;
            musteri4.MusteriKrediNot = 20;

            //herbir değişkenimizi tanımladık.

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            //Musterileri listeleyelim
             foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAd);
                Console.WriteLine(musteri.MusteriTcNo);
                Console.WriteLine(musteri.MusteriId);
                Console.WriteLine(musteri.MusteriYas);
                Console.WriteLine(musteri.MusteriKrediNot);
                Console.WriteLine("\n");
            }


             //ekleme silme

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            Console.WriteLine("\n");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);





            
        }
    }

    //->class tanımlama
    class Musteri
    {
        public string MusteriAd { get; set; }
        public int MusteriTcNo { get; set; }
        public int MusteriId { get; set; }
        public int MusteriYas { get; set; }
        public int MusteriKrediNot { get; set; }



    }
}
