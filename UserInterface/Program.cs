using System;
using P2P;

namespace UserInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PeerServer pServer = new PeerServer();
            pServer.Start();

            Console.ReadLine();

        }
    }
}
