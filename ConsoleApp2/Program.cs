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
            Console.Write("Ortalaması hesaplanacak sayıyı giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
	        {
                toplam+=sayac;
                sayac++;
	        }
            Console.WriteLine("Ortalama: "+toplam/sayi);


            Console.WriteLine("\n*************");

            char chacercter='a';
            while (chacercter < 'z')
            {
                Console.Write(chacercter);
                chacercter++;
            }

         
           Console.WriteLine("\n*************");


           string[] arabalar = {"BMV","FORD", "TOYOTO", "NISSAN"};
           foreach (var item in arabalar)
	       {
               Console.WriteLine(item);
	       }
           Console.ReadLine();
        }
    }
}
