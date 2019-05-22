using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace udpClient_1
{
    class Program
    {
        static void Main(string[] args)
        {

            UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.43.33"), 1345));

            while (true)
            {
                IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);

                byte[] data = udpClient.Receive(ref point);

                string message = Encoding.UTF8.GetString(data);

                Console.WriteLine("收到了消息：" + message);
            }

            udpClient.Close();

            Console.ReadKey();
        }
    }
}
