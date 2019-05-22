using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;

using System.Net;

using System.Threading;

namespace unity聊天室
{
    class Client
    {
        Program p = new Program();

        private Thread t;

        private Socket clientSocket;

        private byte[] data = new byte[1024];

        public Client(Socket s)
        {
            clientSocket = s;

            t = new Thread(ReceiveMessage);

            t.Start();
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                if (clientSocket.Poll(10, SelectMode.SelectRead))
                {
                    
                    clientSocket.Close();

                    
                    
                    break;
                }

                int length = clientSocket.Receive(data);

                string message = Encoding.UTF8.GetString(data, 0, length);

               Program.BroadcastMessage(message);

                Console.WriteLine("收到消息：" + message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            clientSocket.Send(data);
        }

        public bool Connected
        {
            get { return clientSocket.Connected; }
        }
    }
}
