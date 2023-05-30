using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        public int Age { get; set; } // 속성

        public Animal() { this.Age = 0; } // 자기 자신의 생성자

        // 메서드
        public void Eat() { Console.WriteLine("뇸뇸"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
    }
}
