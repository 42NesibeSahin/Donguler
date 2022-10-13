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
            string degisken1="Dersimiz CSharp, Hoşgeldiniz";
            string degisken2="CSharp";

            Console.WriteLine(degisken1.Length);         // karakter sayısı
            Console.WriteLine(degisken1.ToUpper());      // buyuk harfe çevir
            Console.WriteLine(degisken1.ToLower());      // kucuk harfe cevir
            Console.WriteLine(string.Concat(degisken1, "Merhaba")); // degisken1 ekleme yapma
            Console.WriteLine(degisken1.CompareTo(degisken2));  //-1,0,,1
            Console.WriteLine(string.Compare(degisken1, degisken2,true));
            Console.WriteLine(string.Compare(degisken1, degisken2,false));
            Console.WriteLine(degisken1.Contains(degisken2));
            Console.WriteLine(degisken1.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken1.StartsWith("Merhaba"));
            Console.WriteLine(degisken1.IndexOf("CS"));
            Console.WriteLine(degisken1.IndexOf("Nesibe"));
            Console.WriteLine(degisken1.LastIndexOf("Merhaba"));
            Console.WriteLine(degisken2.Insert(0,"Merhaba "));
            Console.WriteLine(degisken1+degisken2.PadLeft(30));
            Console.WriteLine(degisken1+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken1.PadRight(50)+degisken2);
            Console.WriteLine(degisken1.PadRight(50,'*')+degisken2);
            Console.WriteLine(degisken1.Remove(10));
            Console.WriteLine(degisken1.Remove(5,3));
            Console.WriteLine(degisken1.Remove(0,1));
            Console.WriteLine(degisken1.Replace(" ","*"));
           
             Console.WriteLine(degisken1.Replace("CSharp","C#"));
          //  Console.WriteLine(degisken1.Split('')[1]);
            Console.WriteLine(degisken1.Substring(4));
            Console.WriteLine(degisken1.Substring(4,6));



            Console.ReadLine();
        }
    }

    
 }