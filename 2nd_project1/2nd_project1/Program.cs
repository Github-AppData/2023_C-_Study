using System; // 메모리 공간을 절약, 코딩의 길이를 짧게 해준다. - 모듈을 모두 사용하겠습니다 !


// namespace를 사용하는 이유 : 메모리 공간을 사용하려고,
namespace _2nd_project1
{
    class Program // 메모리 공간에 없다. - 설계도 이기 때문에.
    {
        // static을 통해서 메모리에 접근을 해줘야 한다. - 없으면 메모리에 접근하지 못해서 실행 X.
        // Main : 컴파일러의 진입로
        static void Main(string[] args) // static 메모리 공간에 할당, 객체를 선언. (실제로 만들어준다.)
        {
            // 기본용어 : 표현식, 키워드, 식별자, 주석

            /*Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("안녕하세요\n저는 유한대학교 재학중인 김아무개입니다.");

            // 기본 자료형 정수
            Console.WriteLine(100 / 20);
            Console.WriteLine(10 % 3);

            // 실수
            Console.WriteLine(52.0175f + 15.623f);
            Console.WriteLine(52.0f + 15.0f);
            Console.WriteLine(52.0 % 5); // 실수에서는 나머지 연산자 사용안함.

            // 이스케이프 문자.
            Console.WriteLine("컴퓨터\t29000원\tRTX 4080");
            Console.Write("\n");

            // 문자, 문자열
            Console.WriteLine('A');
            Console.WriteLine("ssss");

            // 문자열 연결 연산자 (+)
            Console.WriteLine("안녕하세요" + "김아무개님.");
            Console.WriteLine(256 + "원");

            // 문자 선택 괄호
            Console.WriteLine("고맙습니다." [3]);
            /*Console.WriteLine("고맙습니다."[6]);
            Console.WriteLine("고맙습니다."[5]);

            // boolean - 불 : 참과 거짓을 표현할 때 사용 (불과 비교연산자)
            Console.WriteLine(52 == 273);
            Console.WriteLine(string.Equals("sss", "sss"));
            Console.WriteLine("sssss".Length);

            // 논리 연산자 (!, ||, &&)
            Console.WriteLine(!true);
            Console.WriteLine(DateTime.Now.Hour < 3 || 16 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

            // 변수 : 값을 저장할 때 사용하는 식별자
            // 정수 자료형(int, long)
            int a = 273;
            int b = 222;
            Console.WriteLine(a + b);
            Console.WriteLine(a % b);
            Console.WriteLine(52.273 + 52.22f);*/

            // sizeof (자료형)
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            /*Console.WriteLine("string : " + sizeof(string)); // string 형은 클래스이다. - 메모리 공간이 없다.*/




        }
    }
}
