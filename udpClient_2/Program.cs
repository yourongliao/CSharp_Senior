using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using System.Net.Sockets;

namespace udpClient_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();

            while (true)
            {
                string message = Console.ReadLine();

                byte[] data = Encoding.UTF8.GetBytes(message);

                client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("192.168.43.33"), 1345));
            }

            client.Close();

            Console.ReadKey();
        }
    }
}
