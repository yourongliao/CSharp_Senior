using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace 线程问题_争用条件
{
    class Program
    {
        static void ChangeState(object o)
        {
            MyThreadObject m = o as MyThreadObject;


            while (true)
            {
                lock (m)
                {
                    m.ChangeState();
                }

            }
        }

        static void Main(string[] args)
        {

            MyThreadObject a = new MyThreadObject();

            Thread t = new Thread(ChangeState);

            t.Start(a);

            new Thread(ChangeState).Start(a);

            Console.ReadKey();
        }
    }
}
