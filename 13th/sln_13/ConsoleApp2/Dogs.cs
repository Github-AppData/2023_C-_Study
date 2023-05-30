using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dogs : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈왈왈 "); }
    }
}
