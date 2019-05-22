using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace 文件操作_查看文件夹和文件夹信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo fileInfo = new FileInfo("TextFile1.txt");

            //FileInfo fileInfo = new FileInfo(@"D:\code\visual studio\CSharp_Senior\CSharp_Senior\文件操作_查看文件夹和文件夹信息\bin\Debug\TextFile1.txt");

            //Console.WriteLine(fileInfo.Exists);

            //Console.WriteLine(fileInfo.Name);

            //Console.WriteLine(fileInfo.Directory);

            //Console.WriteLine(fileInfo.Length);

            //Console.WriteLine(fileInfo.IsReadOnly);

            // fileInfo.Delete();

            //fileInfo.CopyTo("lala.txt");

            //FileInfo fileInfo = new FileInfo("sss.txt");

            //if (fileInfo.Exists == false)
            //{
            //    fileInfo.Create();
            //}

            //fileInfo.MoveTo("sasas.txt");

            //Console.ReadKey();

            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\code\visual studio\CSharp_Senior\CSharp_Senior\文件操作_查看文件夹和文件夹信息\bin\Debug");


            Console.WriteLine(dirInfo.Exists);

            Console.WriteLine(dirInfo.Name);

            Console.WriteLine(dirInfo.Parent);

            Console.WriteLine(dirInfo.Root);

            Console.WriteLine(dirInfo.CreationTime);

            dirInfo.CreateSubdirectory("isscuss");

            Console.ReadKey();
        }
    }
}
