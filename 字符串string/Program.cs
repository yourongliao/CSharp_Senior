using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "www.isscuss.com";

            //int length = s.Length;

            //if (s == "www.isscuss.com")
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //}

            //Console.Write(length);

            //Console.ReadKey();

            //s = "http://" + s;

            //Console.WriteLine(s);

            //char c = s[3];

            //Console.WriteLine(c);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //Console.ReadKey();

            //string s = "isscuss";

            //int res = s.CompareTo("isscuss");

            //int res1 = s.CompareTo("isscu");

            //int res2 = s.CompareTo("saq");

            //Console.WriteLine(res);

            //Console.WriteLine(res1);

            //Console.WriteLine(res2);

            //Console.ReadKey();

            //string s = "www.isscuss.com";

            //string newStr = s.Replace('.', '-');

            //Console.WriteLine(s);

            //Console.WriteLine(newStr);

            //Console.ReadKey();

            //string s = "www.isscuss.com";

            //string[] strArray = s.Split('.');

            //foreach (var temp in strArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //Console.ReadKey();

            string s = "   www.   isscuss.   COM   ";

            string str = s.Substring(4, 7);

            string str2 = s.Substring(5);

            Console.WriteLine(str);

            Console.WriteLine(str2);

            string str3 = s.ToUpper();

            string str4 = s.ToLower();

            Console.WriteLine(str3);

            Console.WriteLine(str4);

            string str5 = s.Trim();

            Console.WriteLine(str5);

            int index = s.IndexOf("isscuss");

            Console.WriteLine(index);

            Console.ReadKey();


        }
    }
}
