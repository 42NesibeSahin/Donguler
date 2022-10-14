using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi= new List<int>();
            List<string> renkListesi= new List<string>();

            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(6);
            sayiListesi.Add(12);
            sayiListesi.Add(20);
            sayiListesi.Add(1);
            sayiListesi.Add(70);

            renkListesi.Add("kırmızı");
            renkListesi.Add("sarı");
            renkListesi.Add("mavi");
            renkListesi.Add("yeşil");
            renkListesi.Add("siyah");
            renkListesi.Add("mor");

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            Console.WriteLine("\n*******   Sayılar   *******\n");
            foreach (var item in sayiListesi)
	            Console.WriteLine(item);

            Console.WriteLine("\n*******   Renkler   ********\n");
            foreach (var item in renkListesi)
	            Console.WriteLine(item);

            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");

            sayiListesi.RemoveAt(1);
            renkListesi.RemoveAt(1);

            Console.WriteLine("\n*******   Sayılar   *******\n");
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));

            Console.WriteLine("\n*******   Renkler   ********\n");
            renkListesi.ForEach(sayi=> Console.WriteLine(sayi));

            if(sayiListesi.Contains(12))          //liste içeriside arama
                Console.WriteLine("\n12 liste içerisnde bulundu... ");

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));   //Elemanın indexine erişme

            string[] hayvanlar = {"kedi", "kopek", "inek", "tavsan"};
            List<string> hayvanListesi= new List<string>(hayvanlar);     //diziyi listeye aktarma

            hayvanListesi.Clear();


            List<Kullanicilar> kullanicilarListesi= new List<Kullanicilar>();
            Kullanicilar kullanici1=new Kullanicilar();
            kullanici1.Isim="Nesibe";
            kullanici1.Soyisim="ŞAHİN";
            kullanici1.Yas=23;

            Kullanicilar kullanici2=new Kullanicilar();
            kullanici2.Isim="Fırat Servan";
            kullanici2.Soyisim="ÜÇKARDEŞ";
            kullanici2.Yas=29;
            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe=new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim="Nesibe",
                Soyisim="ŞAHİN",
                Yas=28
            });

            foreach (var item in kullanicilarListesi)
	        {
                Console.WriteLine("Kullanıcı adı: "+item.Isim);
                Console.WriteLine("Kullanıcı soyadı: "+item.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: "+item.Yas);
	        }








            Console.ReadLine();
        }
    }
    public class Kullanicilar
    {
         private string isim ;
         private string soyisim;
         private int yas;

        public int Yas { get => yas; set => yas = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }

    }
    
 }