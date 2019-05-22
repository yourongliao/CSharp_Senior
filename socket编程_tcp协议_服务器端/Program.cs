using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;

using System.Net;

namespace socket编程_tcp协议_服务器端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddress = new IPAddress(new byte[] { 192,168,43,33 });

            EndPoint point = new IPEndPoint(ipaddress, 1345);

            tcpServer.Bind(point);

            tcpServer.Listen(100);

            Socket clientSocket = tcpServer.Accept();

            string message = "欢迎您,希望我的游戏，给你带来开心，是我的荣幸";

            byte[] data = Encoding.UTF8.GetBytes(message);

            clientSocket.Send(data);


            //从客户端接收数据
            byte[] data2 = new byte[1024];
            int length = clientSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);

            Console.WriteLine(message2);

            Console.ReadKey();

        }
    }
}
