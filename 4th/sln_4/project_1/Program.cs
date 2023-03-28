using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자 입력
            /*Console.Write("나이는 몇 살 이십니까 ? : ");
            String age = Console.ReadLine();
            Console.WriteLine(age + "살 입니다.");*/

            // 숫자 입력
            /*Console.Write("나이는 몇 살 이십니까 ? : ");
            int age_int = int.Parse(Console.ReadLine());
            *//*int age_int = Convert.ToInt32(Console.ReadLine());*//*
            Console.WriteLine(age_int+"살 입니다.");*/

            // 강제 자료형 변환
            var a = (int)10.0;
            var b = (double)10;

            // 강제 자료 변환시 자료 손실


            // 문자열을 숫자로 변환
            /*string numStr = "42244";
            int intNum = numStr;*/
            /*
             Console.WriteLine(int.Parse("432"));
             Console.WriteLine(float.Parse("432.1212").GetType());
             Console.WriteLine(int.Parse("ABC"));*/

             // 기본자료형을 문자열로변환
             Console.WriteLine(52);

            Console.WriteLine((32.222).ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine(('a').ToString().GetType());

            // 소수점 제거
            double num = 3.142592;
            Console.WriteLine(num.ToString());
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));

            // 숫자가 자동으로 문자열로 변환
            Console.WriteLine(52+52); // 104
            Console.WriteLine("52" + 273); // 52273

            int nsum = 12123;
            /*String output = nsum + 'a'; // 문자는 문자열 변환 불 가능*/
        }
    }
}
