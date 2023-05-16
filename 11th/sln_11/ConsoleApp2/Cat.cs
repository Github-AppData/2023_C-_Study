using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cat
    {
        public string Name;
        public string Color;
        public int Age;

        public void Meow()
        {

            Console.WriteLine($"{Name} : 야옹");
        }
        public Cat (string name, string color, int age) // 생성자 정의
        {
            Name = name;
            Color = color;
            Age = age;

        }
    }
}
