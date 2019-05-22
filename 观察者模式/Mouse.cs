using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Mouse
    {
        private string name;

        private string color;

        public Mouse(string name,string color)
        {
            this.name = name;

            this.color = color;
        }

        public void RunAway()
        {
            Console.WriteLine(color + "的老鼠" + name + "说：猫来了，快跑");
        }
    }
}
