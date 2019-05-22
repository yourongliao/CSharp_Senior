using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程_委托方式发起线程
{
    class Program
    {
        static int Test(int i,string str)
        {
            Console.WriteLine("test"+i+str);

            Thread.Sleep(100);

            return 100;
        }

        static void Main(string[] args)
        {
            //Func<int,string,int> a = Test;

            //IAsyncResult ar = a.BeginInvoke(100, "isscuss", null, null);


            //Console.WriteLine("main");

            //while (ar.IsCompleted == false)
            //{
            //    Console.Write(".");

            //    Thread.Sleep(10);
            //}

            //int res = a.EndInvoke(ar);

            //Console.WriteLine(res);

            //Console.ReadKey();

            Func<int, string, int> a = Test;

            //IAsyncResult ar = a.BeginInvoke(200, "isscuss", OnCallBack, null);

            a.BeginInvoke(300, "isscuss", ar =>
              {
                  int res = a.EndInvoke(ar);

                  Console.WriteLine(res + "在lambda表达式中取得");
              }, null
                );

            Console.ReadKey();
        }

        static void OnCallBack(IAsyncResult ar)
        {
            Console.WriteLine("子线程结束");
        }
    }
}
