using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace 使用File读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strArray = File.ReadAllLines("TextFile1.txt");

            //foreach (var s in strArray)
            //{
            //    Console.WriteLine(s);
            //}

            //string s = File.ReadAllText("TextFile1.txt");

            //Console.WriteLine(s);

            //byte[] byteArray = File.ReadAllBytes("3.LINQ.png");

            //foreach (var b in byteArray)
            //{
            //    Console.Write(b);
            //}

            // File.WriteAllText("TextFile2.txt", "aniki");

            //File.WriteAllLines("TextFile3.txt", new string[] { "sadadaf", "aq1cq", "阿萨放大" });

            byte[] data = File.ReadAllBytes("3.LINQ.png");

            File.WriteAllBytes("4.png", data);

            Console.ReadKey();
        }
    }
}
