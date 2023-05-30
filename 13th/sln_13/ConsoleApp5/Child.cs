using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Child : Parent
    {
        public Child() : base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }
        public Child(string input) : base(input)
        {
            Console.WriteLine($"Child({input}) : base(input)");
        }
    }
}
