using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace 使用StreamReader鸡儿StreamWriter读写文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("TextFile1.txt");

            //while (true)
            //{

            //    string str = reader.ReadLine();

            //    if (str == null) break;

            //    Console.WriteLine(str);
            //}

            //string str = reader.ReadToEnd();

            //Console.WriteLine(str);

            // char c = (char)reader.Read();

            //Console.WriteLine(c);

            //while (true)
            //{
            //    int res = reader.Read();

            //    if (res == -1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write((char)res);
            //    }
            //}

            //reader.Close();


            //Console.ReadKey();


            StreamWriter writer = new StreamWriter("textfile2.txt");

            while (true)
            {
                string message = Console.ReadLine();

                if (message == "q")
                    break;

                //writer.Write(message);

                writer.WriteLine(message);
            }

            writer.Close();

            //Console.ReadKey();
        }
    }
}
