 using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 언제든지 필요할 때마다 수정 및 추가할 수 있다.
            // <> 제네릭 안에는 데이터 형이 들어와야 한다.
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog()};
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat()};

            // 원소를 참조해서 출력
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            Console.WriteLine();

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

            // 상속 : 부모클래스를 만들어 둠으로써, 자식 클래스들의 메소드 코드 중복을 해결한다.



        }
    }
}
