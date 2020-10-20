using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    class PeerServer
    {
        public void Start()
        {
            // Her kommer koden

            // Vi opretter server
            var server = new TcpListener(IPAddress.Loopback, 4646);
            server.Start();

            while (true)
            {
                var socket = server.AcceptTcpClient();

                Task.Run(() =>
                {
                    var tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        public void DoClient(TcpClient socket)
        {
            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());

            String str = sr.ReadLine();
            Console.WriteLine($"Her er server input: {str}");

            

            sw.Flush();
        }
    }
}
