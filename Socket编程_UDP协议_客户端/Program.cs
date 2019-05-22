using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Socket编程_UDP协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            while (true)
            {
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("192.168.43.33"), 1345);

                string message = Console.ReadLine();

                byte[] data = Encoding.UTF8.GetBytes(message);

                udpClient.SendTo(data, serverPoint);
            }

           

            //Console.ReadKey();
        }
    }
}
