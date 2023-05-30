using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Parent
    {
        public Parent() { Console.WriteLine("Parent"); }
        public Parent(int param) { Console.WriteLine($"Parent : {param}"); }
        public Parent(string param) { Console.WriteLine($"Parent : {param}"); }
    }
}
