using System;
using P2P;

namespace UserInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Filename;
            string IpAddress;
            int Portnumber;
            Console.WriteLine("\n Please enter the name of the file: ");
            Filename = Console.ReadLine();
            Console.WriteLine("\n Please enter Your Ip Address: ");
            IpAddress = Console.ReadLine();
            Console.WriteLine("\n Please enter Your Port Number: ");
            Portnumber = Int32.Parse(Console.ReadLine());

            

        }
    }
}
