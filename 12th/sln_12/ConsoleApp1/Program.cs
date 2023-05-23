using System;

namespace ConsoleApp1
{
    class Program
    {
        static void ChangeA(int input)
        {
            input = 10;
            Console.WriteLine(input);
        }

        class Test
        {
            public int value = 2000;
        }

        // 변수가 접근 못한다.
        static void ChangeB(Test input)
        {
            input.value = 30;
        }

        static void Main(string[] args)
        {
            // 값 복사와 참조 복사.
            // 기본자료형은 값이 들어 있다.
            // 클래스를 통하여 생성된 객체는 참조(주소)가 들어 있다. - C언어의 포인터와는 조금 다르다 = 개념을 차용을 했을 뿐.

            int a1 = 40;
            ChangeA(a1); // 10...40
            Console.WriteLine();

            int a2 = 50;
            int input = a2;
            input = 60;

            ChangeA(a2);
            ChangeA(input);

            /*ChangeB(a2);*/

            Test testA = new Test(); // 인스턴스 객체 - 객체는 값이 아니라, 주소가 저장된다.
            Test testB = testA; // 클래스 변수
            testA.value = 100;
            testB.value = 200;
            Console.WriteLine(testA.value);
        }
    }
}
