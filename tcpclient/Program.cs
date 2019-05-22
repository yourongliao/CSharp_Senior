using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using System.Net.Sockets;

namespace tcpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("192.168.43.33", 1345);

            NetworkStream stream = client.GetStream();

            while (true)
            {
                string message = Console.ReadLine();

                byte[] data = Encoding.UTF8.GetBytes(message);

                stream.Write(data, 0, data.Length);


            }

        }
    }
}
