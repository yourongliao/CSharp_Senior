using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_猫抓老鼠
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

        //public void CatComing()
        //{
        //    Console.WriteLine(color + "的猫" + name + "过来了");
        //}

        //public void CatComing(Mouse mouse1, Mouse mouse2)
        public void CatComing()
        {
            Console.WriteLine(color + "的猫" + name + "过来了");

            //mouse1.RunAway();

            //mouse2.RunAway();

            if (catCome != null)
                catCome();
                  
        }

        public event Action catCome;

    }
}
