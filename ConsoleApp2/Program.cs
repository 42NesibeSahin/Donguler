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
             Console.WriteLine("************* ODEV1 ************ ");

             Console.Write("Kac adet sayi girmek istiyorsunuz: ");
             int sayi1=int.Parse(Console.ReadLine());
             int[] dizi1=new int[sayi1];
             for (int i = 0; i < sayi1; i++)
	         {
                Console.Write("sayi giriniz :");
                dizi1[i]=int.Parse(Console.ReadLine());
	         }
             Console.WriteLine("Girilen sayilardan çift sayi olanlar ");
             foreach (var item in dizi1)
	         {
                if(item%2==0)
                    Console.WriteLine(item);
	         }



             Console.WriteLine("************* ODEV2 ************ ");

             Console.Write("ilk sayıyı giriniz: ");
             int sayi2_1=int.Parse(Console.ReadLine());
             Console.Write("ikinci sayıyı giriniz: ");
             int sayi2_2=int.Parse(Console.ReadLine());
             int[] dizi2=new int[sayi2_1];
             for (int i = 0; i < sayi2_1; i++)
	         {
                Console.Write("sayi giriniz :");
                dizi2[i]=int.Parse(Console.ReadLine());
	         }
             Console.WriteLine("Girilen sayilardan eşit veya tam bölünen sayilar ");
             foreach (var item in dizi2)
	         {
                if(item%sayi2_2==0 || item==sayi2_2)
                    Console.WriteLine(item);
	         }



             Console.WriteLine("************* ODEV3 ************ ");

             Console.Write("Kac adet kelime girmek istiyorsunuz: ");
             int sayi3=int.Parse(Console.ReadLine());
             string[] dizi3=new string[sayi3];
             for (int i = 0; i < sayi3; i++)
	         {
                Console.Write("kelime giriniz :");
                dizi3[i]=Console.ReadLine().ToString();
             }
             Array.Reverse(dizi3);
             Console.WriteLine("Girilen kelimlerin sondan başa doğru yazılışı");
             foreach (var item in dizi3)
                    Console.WriteLine(item);



             Console.WriteLine("************* ODEV4 ************ ");
             Console.Write("Bir cümle yazınız: ");
             harfSay(Console.ReadLine());


             Console.ReadLine();
        }
        private static void harfSay(string cumle)
        {
            if (!string.IsNullOrWhiteSpace(cumle))
            {
                int sayac = cumle.Length;
                string harf = cumle.Substring(0, 1);
                cumle = cumle.Replace(harf, "");
                sayac -= cumle.Length;
                Console.WriteLine($"{harf} -> {sayac} Adet");
                harfSay(cumle);
            }
        }
        
    }

    
 }