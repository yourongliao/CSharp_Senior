using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace 线程_通过Thread发起线程
{
    class MyThread
    {
        private string filename;

        private string filepath;

        public MyThread(string filename, string filepath)
        {
            this.filename = filename;

            this.filepath = filepath;
        }

        public void DownFile()
        {
            //Console.WriteLine(filename + ":" + filepath);
            
            Console.WriteLine("开始下载" + filepath + filename);

            Thread.Sleep(2000);

            Console.WriteLine("下载完成");
        }
    }
}
