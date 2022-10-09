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

            int month= DateTime.Now.Month;
            string ay;
            switch (month)
            {
                  case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 5:
                    Console.WriteLine("Haziran");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                default:
                    Console.WriteLine("Hatalı giris");
                    break;

            }
            
            switch (month)
	        {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilk bahar");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("son bahar");
                    break;
		        default:
                    break;
	        }
            Console.ReadLine();
        }
    }
}
