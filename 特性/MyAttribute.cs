using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 特性
{
    [AttributeUsage(AttributeTargets.Class)]
    sealed class MyAttribute:System.Attribute
    {
        public string Description { get; set; }

        public string VersionNumber { get; set; }

        public int ID { get; set; }

        public MyAttribute(string des)
        {
            this.Description = des;
        }
    }
}
