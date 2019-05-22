using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func委托
{
    class Program
    {
        static int Test()
        {
            return 1;
        }

        static int Test2(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Func<int> a = Test;

            Console.WriteLine(a());

            Func<int,int,int> b = Test2;

            Console.WriteLine(b(1,2));

            Console.ReadKey();
        }
    }
}
