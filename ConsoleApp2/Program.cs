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
          int result=1;
            for (int i = 1; i < 5; i++)
			{
                result=result*3;
			}
            Console.WriteLine(result);

            Islemler sinif_islem=new Islemler();
            Console.WriteLine(sinif_islem.Kuvvet(3,4));

            string ifade="Nesibe ŞAHİN";

           
            bool sonux=ifade.BoslukVarMi();
            Console.Write(sonux);

            Console.WriteLine(ifade.BuyukHarfeCevir());
            Console.WriteLine(ifade.KucukHarfeCevir());
            int[] dizi = {1,4,8,75,3};
            dizi.KucuktenBuyugeSirala();
            dizi.EkranaYazdir();

            int sayi=5;
           Console.WriteLine(ifade.IlkKarakter());
           Console.WriteLine(sayi.CiftSayiMi());



            Console.ReadLine();
        }
        
    }

    public class Islemler
    {
        public int Kuvvet(int sayi,int us)
        {
            if(us<2)
                return sayi;
            return Kuvvet(sayi,us-1)*sayi;
        }
    }

    public static class Extension
    {
        public static bool  BoslukVarMi(this string param)
        {
            return param.Contains(" ");
        }

        
     

      // public static string ElemaDegistir(this string param)
       // {
       //     string[] dizi=param.Split(" ");
       //     return string.Join(" ",dizi);
       // }

        public static string BuyukHarfeCevir(this string param)
        {
            return param.ToUpper();
        }

        public static string KucukHarfeCevir(this string param)
        {
            return param.ToLower();
        }

        public static int[] KucuktenBuyugeSirala(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }

        public static bool CiftSayiMi(this int param)
        {
            return param%2==0;
        }

        public static string IlkKarakter(this string param)
        {
            return param.Substring(0,1);
        }


    }

    
 }