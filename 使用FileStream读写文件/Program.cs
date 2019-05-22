using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream stream = new FileStream("TextFile1.txt", FileMode.Open);

            //byte[] data = new byte[1024];

            //int length = stream.Read(data, 0, data.Length);

            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write(data[i] + " ");
            //}

            //Console.ReadKey();

            FileStream readStream = new FileStream("3.LINQ.png", FileMode.Open);

            FileStream writeStream = new FileStream("LINQ_Test.png", FileMode.Create);

            byte[] data = new byte[1024];

            while (true)
            {
                int length = readStream.Read(data, 0, data.Length);

                if (length == 0)
                {
                    Console.WriteLine("读取结束");

                    break;
                }
                else
                {
                    writeStream.Write(data, 0, length);
                }
            }

            writeStream.Close();

            readStream.Close();

            Console.ReadKey();
        }
    }
}
