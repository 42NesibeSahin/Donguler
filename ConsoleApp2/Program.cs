using System;
using System.Collections;
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
          ArrayList liste=new ArrayList();  
           liste.Add("Ayşe");
           liste.Add(2);
           liste.Add(true);
           liste.Add('A');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("******* Add Range  *********");
            string[] renkler = {"kırmızı","sarı","yeşil" };
            liste.AddRange(renkler);

             foreach (var item in liste)
                Console.WriteLine(item);

            ArrayList liste2=new ArrayList();
            List<int> sayilar=new List<int>(){1,5,7,8,2,6};
            liste2.AddRange(sayilar);

             Console.WriteLine("****************");
             foreach (var item in liste2)
                Console.WriteLine(item);

              Console.WriteLine("***************");

             liste2.Sort();
             foreach (var item in liste2)
                Console.WriteLine(item);

             Console.WriteLine("***************");

            Console.WriteLine(liste2.BinarySearch(5));

            liste2.Reverse();
             foreach (var item in liste2)
                Console.WriteLine(item);

             liste2.Clear();
            

            Console.ReadLine();
        }
    }
   
    
 }