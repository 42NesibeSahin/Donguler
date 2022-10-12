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
            int a=2, b=3;
            Console.WriteLine(a+b);

            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar sinif=new Metotlar();
            sinif.Yazdir(sonuc.ToString());

             int sonuc2=sinif.ArttırVeTopla(ref a,ref b);
             sinif.Yazdir(sonuc2.ToString());

          
             Console.ReadLine();
        
        }
        public static int Topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }
    }

    class Metotlar
    {
        public void Yazdir(string yazi)
        {
            Console.WriteLine(yazi);
        }
        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return (deger1+deger2);
        }
    }
 }