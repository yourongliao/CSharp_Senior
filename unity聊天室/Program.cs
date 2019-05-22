using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using System.Net.Sockets;

namespace unity聊天室
{
    class Program
    {
        static List<Client> clientList = new List<Client>();

        

        

        public static void BroadcastMessage(string message)
        {
            var notConnectedList = new List<Client>();

            foreach (var client in clientList)
            {
                if (client.Connected)
                {
                    client.SendMessage(message);
                }
                else
                {
                    notConnectedList.Add(client);
                }
            }

            foreach (var temp in notConnectedList)
            {
                clientList.Remove(temp);

                Console.WriteLine("移除成功");
            }
        }

      

        static void Main(string[] args)
        {

            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.43.33"), 1345));

            tcpServer.Listen(100);

            while (true)
            {
                Socket clientSocket = tcpServer.Accept();

                Console.WriteLine("连上了");

                Client client = new Client(clientSocket);

                clientList.Add(client);

                
            }
        }
    }
}
