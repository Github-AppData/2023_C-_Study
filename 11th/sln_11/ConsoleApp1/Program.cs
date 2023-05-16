using System;

namespace ConsoleApp1
{
    class MyMath
    {
        public static int ABS(int input)
        {
            if(input < 0) { return -input;}
            else {return input;}
        }

        public static double ABS(double input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }

        public static long ABS(long input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }

        public static int Plus (int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)");
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)");
            return a + b + c;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 오버로딩 : 하나의 메서드 이름에 여러 개의 구현을 올리는 것을 뜻한다.
            Console.WriteLine(MyMath.ABS(-2211));
            Console.WriteLine(MyMath.ABS(-222.222));
            Console.WriteLine();

            Console.WriteLine(MainApp);
        }
    }
}
