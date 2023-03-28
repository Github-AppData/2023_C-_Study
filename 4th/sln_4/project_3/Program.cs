using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11
            Console.Write("inch _-> cm 변환기 : ");
            int inch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inch + " inch = " + inch * 2.54f + "cm");

            // 12
            Console.Write("kg -> pound 변환기 : ");
            int kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kg + " kg = " + 2.20462262 * kg + "pound");

            // 13
            float pi = 3.141592f;

            Console.Write("반지름을 입력하시오. ");
            int ban = Convert.ToInt32(Console.ReadLine());
            float dol = 2 * pi * ban;
            float sjfqdl = pi * MathF.Sqrt(ban);

            Console.WriteLine("반지름 " + ban + "의 둘레는 " + dol + "\t넓이는 " + sjfqdl);
        }
    }
}
