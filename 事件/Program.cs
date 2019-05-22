using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Program
    {
        public delegate void MyDelegate();

        public event MyDelegate mydelgate;

        static void Main(string[] args)
        {
            Program p = new Program();

            p.mydelgate = Test1;

            p.mydelgate();

            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("test1");
        }
    }
}
