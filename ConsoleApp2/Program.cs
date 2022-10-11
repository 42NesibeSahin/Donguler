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
            int[] dizi = {15,25,65,75,8,7,88,12};
            foreach (var item in dizi)
	        {
                Console.WriteLine(item);
            }
	        
             Console.WriteLine("\n///////////////\n");
            
            Array.Sort(dizi);
            foreach (var item in dizi)
	        {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n///////////////\n");
            
            Array.Clear(dizi,2,2);
             foreach (var item in dizi)
	         {
                Console.WriteLine(item);
             }

             Console.WriteLine("\n///////////////\n");

            Array.Reverse(dizi);
             foreach (var item in dizi)
	         {
                Console.WriteLine(item);
             }

             Console.WriteLine("\n///////////////\n");

             Console.WriteLine(Array.IndexOf(dizi,65));

              Console.WriteLine("\n///////////////\n");

             Array.Resize<int>(ref dizi,9);
            dizi[8]=2;
             foreach (var item in dizi)
	         {
                Console.WriteLine(item);
             }

           
           Console.ReadLine();
        }
    }
}
