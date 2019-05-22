using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        private delegate string GetAString();

        static void Main(string[] args)
        {
            //int x = 40;

            //string s = x.ToString();

            //GetAString a = new GetAString(x.ToString);

            //string a1 = a();

            //Console.WriteLine(s);

            //Console.WriteLine(a1);

            //Console.ReadKey();

            //int x = 40;

            //GetAString a = x.ToString;

            //string s = a.Invoke();

            //Console.WriteLine(s);

            //Console.ReadKey();

            PrintString method1 = Method1;

            PrintStr(method1);

            PrintString method2 = Method2;

            PrintStr(method2);

            Console.ReadKey();


        }

        private delegate void PrintString();

        static void PrintStr(PrintString a)
        {
            a();
        }

        static void Method1()
        {
            Console.WriteLine("method1");
        }

        static void Method2()
        {
            Console.WriteLine("method2");
        }
    }
}
