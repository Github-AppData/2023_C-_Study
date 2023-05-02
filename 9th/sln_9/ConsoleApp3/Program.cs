using System;

namespace ConsoleApp3
{
    class Program
    {
        // 클래스에 멤버에는 메서드, 생성자 (초기화를 시킨다. - 초기 값 설정),
        // 변수, 프로퍼티가 들어갈 수 있다.
        class Cat
        {
            public string Name;
            public string Color;
            
            // 메서드
            public void Meow() 
            {
                Console.WriteLine($"{Name} : Meow");    
            }

            // 생성자
            public Cat(string name, string color) // 생성자 정의 (선언) - 객체를 초기화
            {
                Name = name;
                Color = color;
            }
        }

        static void Main(string[] args)
        {
            /*Cat c1 = new Cat();*/
            Cat c1 = new Cat("네로", "yellow"); // 생성자가 없으면 안된다.

            /*c1.name = "네로";
            c1.color = "yellow";*/
            c1.Meow();
            Console.WriteLine($"{c1.Name} : {c1.Color}");

            Console.WriteLine();

            Cat c2 = new Cat("키티", "brown"); // 생성자가 없으면 안된다.
            c2.Meow();
            Console.WriteLine($"{c2.Name} : {c2.Color}");
        }
    }
}
