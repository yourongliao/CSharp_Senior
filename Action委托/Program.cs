using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托
{
    class Program
    {
        static void PrintString()
        {
            Console.WriteLine("hello world");
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            Action a = PrintString;

            a();

            Action<string> b = Print;

            b("sas");

            Action<int,int> c = Add;

            Add(1, 2);

            Console.ReadKey();
        }
    }
}
