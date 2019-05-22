using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace 线程_通过Thread发起线程
{
    class Program
    {
        static void DownloadFile()
        {
            Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);

            Console.WriteLine("下载完毕");

        }

        static void Main(string[] args)
        {
            //Thread t = new Thread(DownloadFile);

            //t.Start();

            //Console.WriteLine("Main");

            //Console.ReadKey();



            //Thread t = new Thread(() =>

            //{
            //    Console.WriteLine("开始下载:" + Thread.CurrentThread.ManagedThreadId); ;

            //    Thread.Sleep(2000);

            //    Console.WriteLine("下载完成");
            //}

            //);

            //t.Start();


            //Thread t = new Thread(DownloadFile);

            //t.Start();

            //Console.WriteLine("start");

            //Console.ReadKey();

            //MyThread my = new MyThread("sas","地址");

            //Thread t = new Thread(my.DownFile);

            //t.Start();

            //Console.ReadKey();

            Thread t = new Thread(DownloadFile);

            //t.Start();

            t.IsBackground = true;

            t.Start();

            //t.Abort();

            t.Join();

            Console.WriteLine("继续");

            Console.ReadKey();

            


        }
    }
}
