using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "akif";
            musteri1.Soyad = "eren";
            musteri1.Id = 1;
            musteri1.Yas = 20;


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "mehmet";
            musteri2.Soyad = "eren";
            musteri2.Id = 2;
            musteri2.Yas = 45;



            Musteri musteri3 = new Musteri();
            musteri3.Ad = "recep";
            musteri3.Soyad = "ivedik";
            musteri3.Id = 3;
            musteri3.Yas = 12;


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri x in musteriler)
            {
                Console.WriteLine("Musteri Ad: " + x.Ad );
                Console.WriteLine("Musteri Soyad: " + x.Soyad);
                Console.WriteLine("Musteri Id: " + x.Id);
                Console.WriteLine("Musteri Yas: " + x.Yas);
                Console.WriteLine("---------------------------------");
            }

           

        }
    }
}
