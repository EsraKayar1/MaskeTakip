using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            Vatandas vatandas1 = new Vatandas(); //Bir tane vatandas oluşturduk.Buna "Instances" denir 

            SelamVer("Esra");
            SelamVer("Emin");
            SelamVer();
            Toplam(5, 3);

            Console.WriteLine();

            //Diziler / Arrays

            string ogrenciler1 = "Engin";
            string ogrenciler2 = "Kerem";
            string ogrenciler3 = "Berkay";

            Console.WriteLine(ogrenciler1);
            Console.WriteLine(ogrenciler2);
            Console.WriteLine(ogrenciler3);
            
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";
           

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            Console.WriteLine();

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler1 = sehirler2;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")  //isim adında parametre aldık
        {
            Console.WriteLine("Merhaba "+ isim);
        }
        static int Toplam(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam "+sonuc.ToString());
            return sonuc;
        }
    }
    
    class Vatandas //vatandas sınıfı
    {
        public string Ad{ get; set; }
        public string Soyad{ get; set; }
        public int DogumYili{ get; set; }
        public long TcNo{ get; set; }

        /*
     set ve get metodu isim girilen müşterinin sonraki sayfada isimdan sonra "Bey" ya da "Hanım" gibi ünvanlar verilebilmesini sağlar  
     */

        //string ad = "Esra";
        //string soyad = "Kayar";
        //int dogunYili = 1985;
        //long tcNo = 12345678910;

    }
}
