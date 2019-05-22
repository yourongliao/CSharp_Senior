using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();

            //Type type = myClass.GetType();

            //Console.WriteLine(type.Name);

            //Console.WriteLine(type.Namespace);

            //Console.WriteLine(type.Assembly);

            //FieldInfo[] array = type.GetFields();

            //foreach (FieldInfo info in array)
            //{
            //    Console.WriteLine(info.Name + " ");
            //}

            //PropertyInfo[] array2 = type.GetProperties();

            //foreach (PropertyInfo info in array2)
            //{
            //    Console.Write(info.Name+" ");



            //}

            //MethodInfo[] array3 = type.GetMethods();


            //foreach (MethodInfo info in array3)
            //{
            //    Console.Write(info.Name + " ");
            //}

            MyClass myClass = new MyClass();

            Assembly assem = myClass.GetType().Assembly;

            Console.WriteLine(assem.FullName);

            Type[] types = assem.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type);
            }

            Console.ReadKey();
        }
    }
}
