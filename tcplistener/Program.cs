using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using System.Net.Sockets;

namespace tcplistener
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("192.168.43.33"), 1345);

            listener.Start();

            TcpClient client = listener.AcceptTcpClient();

            NetworkStream stream = client.GetStream();

            byte[] data = new byte[1024];

            while (true)
            {
                int length = stream.Read(data, 0, 1024);

                string message = Encoding.UTF8.GetString(data, 0, length);

                Console.WriteLine("收到了消息：" + message);
            }

           

            stream.Close();

            client.Close();

            listener.Stop();
        }
    }
}
