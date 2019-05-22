using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace socket编程_tcp协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddress = IPAddress.Parse("192.168.43.33");

            EndPoint point = new IPEndPoint(ipaddress, 1345);

            tcpClient.Connect(point);

            byte[] data = new byte[1024];

            int length = tcpClient.Receive(data);

            string message = Encoding.UTF8.GetString(data, 0, length);

            Console.WriteLine(message);

            //向服务器端，发送数据
            string message2 = Console.ReadLine();

            tcpClient.Send(Encoding.UTF8.GetBytes(message2));

            Console.ReadKey();

        }
    }
}
