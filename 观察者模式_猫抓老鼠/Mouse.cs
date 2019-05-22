using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_猫抓老鼠
{
    class Mouse
    {
        private string color;

        private string name;

        public Mouse(string name, string color,Cat cat)
        {
            this.name = name;

            this.color = color;

            cat.catCome += this.RunAway;
        }

        public void RunAway()
        {
            Console.WriteLine(color + "的老鼠" + name + "说，猫来了，快跑");
        }
    }
}
