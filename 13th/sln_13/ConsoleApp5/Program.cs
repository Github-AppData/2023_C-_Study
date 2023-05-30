using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 부모 생성자를 명시적으로 표시하고 싶으면, base 키워드를 이용해라
            // 상속 받아서 처리 하는 것은 생성자 호출 순서와 어떻게 호출하는지 잘 기억 해 놔야 한다. ★★★★★
            Child childA = new Child();
            Child childB = new Child("김태욱");
        }
    }
}
