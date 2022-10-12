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
            string sayi="123";
            bool sonuc=int.TryParse(sayi,out int outSayi);
            if(sonuc)
                Console.WriteLine("İşlem başarılı :"+ outSayi);
            else
                Console.WriteLine("işlem başarısız");

            
            Metotlar sinif=new Metotlar();
            sinif.Topla(4,5,out int toplamSonuc);
            sinif.EkranaYazdir(toplamSonuc);
            sinif.EkranaYazdir("Nesibe","şahin");
            sinif.EkranaYazdir("7");

            Console.ReadLine();
        }
        
    }

    class Metotlar
    {
       public void Topla(int a,int b , out int toplam)
        {
            toplam=a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+ veri2);
        }
    }
 }