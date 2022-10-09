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
            Console.WriteLine("Nesibe SAHİN");

            Console.WriteLine("Bir sayi giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
			{
                if(i%2==1)
                    Console.WriteLine(i);
			}

            Console.WriteLine("*****************");

            int tekSayi=0;
            int ciftSAyi=0;
            for (int i = 1; i <= sayi; i++)
		    {
                if(i%2==1)
                 tekSayi =+ tekSayi+i;
                else
                 ciftSAyi =+ ciftSAyi+i;
		    }

             Console.WriteLine("Tek sayi:"+tekSayi);
             Console.WriteLine("cift sayi :"+ciftSAyi);


            Console.WriteLine("*****************");

            for (int i = 1; i <= sayi; i++)
			{
                if(i==4)
                    break;
                Console.WriteLine(i);
			}

            Console.WriteLine("*****************");
             for (int i = 1; i <= sayi; i++)
			{
                if(i==4)
                    continue;
                Console.WriteLine(i);
			}
    
            Console.ReadLine();
        }
    }
}
