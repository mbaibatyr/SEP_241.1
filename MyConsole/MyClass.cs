using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class MyClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MyClass()
        { }
        public MyClass(string name, string desc)
        { 
            Name = name;
            Description = desc;
        }

        public void GetData()
        {
            Console.WriteLine($"{Name} - {Description}");
        }
    }
}
