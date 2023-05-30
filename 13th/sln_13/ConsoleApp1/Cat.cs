using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat
    {
        public int Age { get; set; } // 속성

        public Cat() { this.Age = 0; } // 자기 자신의 생성자

        // 메서드
        public void Eat() { Console.WriteLine("냥냥"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
        public void Meow() { Console.WriteLine("냐옹"); }
    }
}
