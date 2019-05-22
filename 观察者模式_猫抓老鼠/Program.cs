using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_猫抓老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲猫", "蓝色");

            Mouse mouse1 = new Mouse("啦啦啦", "黄色", cat);

            //cat.catCome += mouse1.RunAway;

            Mouse mouse2 = new Mouse("保护费", "黑色", cat);

            //cat.catCome += mouse2.RunAway;

            Mouse mouse3 = new Mouse("索拉鲁斯", "紫色", cat);

            //cat.catCome += mouse3.RunAway;

            cat.CatComing();

            


            Console.ReadKey();
        }
    }
}
