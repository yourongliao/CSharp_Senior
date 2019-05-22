using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using System.Net.Sockets;

using System.Threading;

namespace socket编程_UDP协议_服务器端
{
    class Program
    {
        private static Socket udpServer;

        static void Main(string[] args)
        {
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            udpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.43.33"), 1345));

            new Thread(ReceiveMessage) { IsBackground = true }.Start();

            //udpServer.Close();

            Console.ReadKey();
        }

        static void ReceiveMessage()
        {
            while (true)
            {
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

                byte[] data = new byte[1024];

                int length = udpServer.ReceiveFrom(data, ref remoteEndPoint);

                string message = Encoding.UTF8.GetString(data, 0, length);

                


                Console.WriteLine("从ip：" + (remoteEndPoint as IPEndPoint).Address.ToString() + ":"
                    + (remoteEndPoint as IPEndPoint).Port + "收到了数据：" + message);
            }

           
        }
    }
}
