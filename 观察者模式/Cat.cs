using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
     class Cat
    {
        private string name;

        private string color;

        public Cat(string name, string color)
        {
            this.name = name;

            this.color = color;
        }

        public void CatComing()
        {
            Console.WriteLine(color + "的猫" + name + "过来了");
        }
    }
}
