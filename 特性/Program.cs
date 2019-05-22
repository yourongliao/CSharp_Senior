#define IsTest


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

using System.Runtime.CompilerServices;

namespace 特性
{
    [My("自定义特性",ID=100)]
    class Program
    {
        [Obsolete("最好不要使用这个方法啦", true)]
        static void OldMethod()
        {
            Console.WriteLine("旧方法");
        }

        [Conditional("IsTest")]
        static void Test1()
        {
            Console.WriteLine("test1");
        }

        static void Test2()
        {
            Console.WriteLine("test2");
        }

        [DebuggerStepThrough]
        static void PrintOut(string str, [CallerFilePath] string fileName = "", [CallerLineNumber]int lineNumber = 0, [CallerMemberName]string methodName = "")
        {
            Console.WriteLine(str);

            Console.WriteLine(fileName);

            Console.WriteLine(lineNumber);

            Console.WriteLine(methodName);
        }

        static void Main(string[] args)
        {
            //OldMethod();

            //Test1();

            //Test2();

            //Test1();

            //PrintOut("123");


            Type type = typeof(Program);

            object[] array = type.GetCustomAttributes(false);

            MyAttribute mytest = array[0] as MyAttribute;

            Console.WriteLine(mytest.Description);

            Console.WriteLine(mytest.ID);


            Console.ReadKey();
        }
    }
}
