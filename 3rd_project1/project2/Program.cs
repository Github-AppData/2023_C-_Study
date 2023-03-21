using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 솔루션에 main은 하나여야 한다.
            // main = 진입점.
            // main 변경
            // 1. 솔루션 부분 우클릭
            // 2. 속성
            // 3. 현재 선택영역 클릭

            // 문자열 서식 맞추기
            /* 
             * Console.WriteLine(); -> 기본적으로 문자열을 출력하는 메서드
             * - 숫자를 출력할 때는 문자열로 변환하는 과정이 필요하다.
             * 
             * C#은 문자열 서식화에 사용할 수 있는 간단한 두 가지 방법을 제공하고 있다.
             * 
             * ① string 형식의 Format 매서드.
             * ② 문자열 보간 (Interpolation)
             */

            // 1. string 형식의 Format 메서드
            // {} - 서식화된 틀

            // 시험문제에 무조건 나온다. - string 형식에서 문자열 보간으로 바꾸는 거 (거꾸로도)
            /*Console.WriteLine("학과 : " + "컴소과");
            Console.WriteLine("학과 : {0}", "컴소과"); // 1. string 형식의 Format 메서드
            Console.WriteLine($"학과 : {"컴소과"}"); // 문자열 보간 

            Console.WriteLine("{0}, {1}", "ssss", "Ssaaa");
            Console.WriteLine($"{"ssss"}, {"aaaaa"}");

            // 서식항목
            // {첨자, 맞춤, 서식문자열}  
            Console.WriteLine("Total : {0, 7:D}", 123); // 첨자 : 0 , 맞춤 : 7, 서식 문자열 : D (십진수)
            Console.WriteLine("Total : {0, -7:D}", 123); // 첨자 : 0 , 맞춤 : -7, 서식 문자열 : D (십진수)

            // "이게 무슨 뜻이구나" 알아야 한다.
            Console.WriteLine("{0, -10:D5}", 12);
            Console.WriteLine("{0, 10:D5}", 12222);

            int n = 233;
            string s = "멋진 컴소공";
            Console.WriteLine("string 형식 : {0}, {1}", n, s);
            Console.WriteLine($"문자열 보간법 : {n}, {s}");

            string fmt = "{0, -15}, {1, -20}, {2, 10}";
            Console.WriteLine(fmt, "Computer", "Hong Gildong", "Programing");

            Console.WriteLine("{0}", 123456789); 
            Console.WriteLine("{0:N}", 123456789); // 입력된 수를 콤마로 구분하여 출력 - 소숫점 아래 자리까지.
            Console.WriteLine("{0:N0}", 123456789); // 입력된 수를 콤마로 구분하여 출력 
            Console.WriteLine("{0:F}", 123456789); */

            // 자료형 변환
            // 강제 자료형 변환 - 캐스팅
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)20;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // 데이터 손실 8 byte -> 4 byte (큰 바이트에서 작은 바이트로 갈 때 데이터 손실이 일어난다.)
            // 손실이 되서 오류가 남.
            long longNumber = 211112332L + 21112312323L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);


        }
    }
}
