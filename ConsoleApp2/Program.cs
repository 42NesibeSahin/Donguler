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
            int time=DateTime.Now.Hour;
            if(time>=6 && time<11)
                Console.WriteLine("Günaydın");
            else if(time<=18)
                Console.WriteLine("iyi günler");
            else 
                Console.WriteLine("iyi geceler");

            string sonuc=time>=6 && time<11 ?"Günaydın": time<=18? "iyi günler":"iyi geceler";
             Console.WriteLine(sonuc);
                
           
            Console.ReadLine();
        }
    }
}
