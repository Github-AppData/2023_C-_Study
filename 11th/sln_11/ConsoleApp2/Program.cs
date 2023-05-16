using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 접근 제한자 (한정자)
            /*
             * 은익성 : 객체지향 프로그래밍은 클래의 사용자에게 필요한 
             * 최소한의 기능 만을 노출하고, 내부를 감출 것을 요구한다. - 이것을 은익성이라고 한다.
             * 
             ※ C#에서 제공하는 접근 제한자
             public : 
             protected : 
             private : 클래스의 내부에서만 접근
             internal : 
             protected internal : 
             private protected : 
             * 
             */

            // 생성자
            // 생성자의 클래스와 이름이 같고, 반환형식이 없더.
            // 왜 생성자가 필요한가 ?
            // 생성자의 임무는 단 한가지 -> 해당 형식 (클래스)의 객체를 생성하는 것
            // 왜 생성자를 구현해야 하나 ?
            // -> 객체의 필드(변수)를 원하는 값으로 초기화 하고 싶을 때 구현
            Cat cat = new Cat("미야", "파란색", 3);
            cat.Meow();
            Console.WriteLine($"{cat.Name} : {cat.Age} {cat.Color}");

            Console.WriteLine();
            Cat nero = new Cat("네로", "검은색", 3);
            cat.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Age} {nero.Color}");
        }
    }
}
