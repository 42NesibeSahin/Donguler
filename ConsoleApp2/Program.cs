using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler=new string[5];
            string[] hayvanlar = {"kedi", "kopek", "inek", "sinek"};
            int[] dizi;
            dizi=new int[5];

            renkler[0]="siyah";
            renkler[1]="beyaz";
            dizi[0]=5;
            dizi[3]=4;

            Console.WriteLine(renkler[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[0]);

            Console.WriteLine("\n***************\n");

            Console.WriteLine("Lütfen dizi elaman sayisini giriniz:");
            int sayi_uzunluk=int.Parse(Console.ReadLine());
            int[] sayiDizisi= new int[sayi_uzunluk];
            int toplam=0;
            for (int i = 0; i < sayi_uzunluk; i++)
			{
                Console.Write("{0}. elamanı giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
                toplam += sayiDizisi[i];
			}

            Console.WriteLine("Ortalama : "+ toplam/sayi_uzunluk);


           Console.ReadLine();
        }
    }
}
