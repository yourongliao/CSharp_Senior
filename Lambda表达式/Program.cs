using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> plus = (arg1, arg2) =>
            //    {
            //        return arg1 + arg2;
            //    };

            //Console.WriteLine(plus(20, 45));

            //Console.ReadKey();

            Func<int, int> test2 = a => a + 1;

            Func<int, int> test3 = (a) =>
               {
                   return a + 1;
               };

            Console.WriteLine(test2(34));

            Console.WriteLine(test3(34));

            Console.ReadKey();
        }
    }
}
