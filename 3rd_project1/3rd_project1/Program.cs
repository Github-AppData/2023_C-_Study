using System;

namespace _3rd_project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// 복합 대입연산자
            int input = 0;
            input += 57;
            input += 173;

            Console.WriteLine(input);

            // 문자열 연결 연산자
            Console.WriteLine(10+19);
            Console.WriteLine(10+"원");
            Console.WriteLine(10+'원');
            Console.WriteLine("10"+"20");
            Console.WriteLine("최강" + "컴시스");

            // 증간 연산자
            int num1 = 10;
            num1++;
            Console.WriteLine(num1);
            num1--;
            Console.WriteLine(num1);*/

            /*int num2 = 20;
            Console.WriteLine(num2);
            Console.WriteLine(num2++);
            Console.WriteLine(num2--);
            Console.WriteLine(num2);
            Console.WriteLine(--num2);
            Console.WriteLine(num2--);*/

            // 자료형
            // 변수선언
            int _int = 3123;
            long _long = 123123123123123;
            float _float = 32.2222f;
            double _double = 23.333;
            char _char = '글';
            string _string = "문자열";

            // GetType() 메서드를 활용해서 자료형 출력
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());

            // 직접적인 GetType() 메서드를 활용해서 자료형 출력
            Console.WriteLine((52.225f).GetType());

            // 교재에 없는 부분
            // var 키워드
            /* 지역변수로 선언 할 때 var 키워드를 사용한다. 
             * 
             * 주의점
               1. 전역변수로 var키워드 사용하면 -> 오류 발생 
               2. 변수 선언과 동시에 초기화 선언해야 한다. */

            // var 사용하는 이유
            // 메모리 공간이 미리 준비 되어져야 한다 - 원래
            // var - 초기 값이 무엇이냐에따라 자료형이 정해진다. (입력 받을 값이 무엇인지 모를 때 유용하게 사용.)
            var global = 199;
            var num12 = 45.2;
            var num22 = 32.2f;

            Console.WriteLine(global.GetType());






        }

    }
}
