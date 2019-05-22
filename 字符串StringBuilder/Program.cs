using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("sasasas");

            //StringBuilder sb2 = new StringBuilder(30);

            //StringBuilder sb3 = new StringBuilder("sasasa;ksl;a", 100);

            //sb3.Append("xxx.com");

            //Console.WriteLine(sb3.ToString());

            //Console.ReadKey();

            //string s = "wawasa";

            //s = s + ".com";

            //Console.WriteLine(s);

            //Console.ReadKey();

            StringBuilder sb = new StringBuilder("sasasa;ksl;a", 100);

            //sb.Insert(1, "http://");

            //Console.WriteLine(sb);

            //sb.Remove(1, 3);

            //Console.WriteLine(sb);

            //Console.ReadKey();

            sb.Replace(";", "@");

            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
