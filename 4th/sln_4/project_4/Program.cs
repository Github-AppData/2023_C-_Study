using System;

namespace project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 조건문

            Console.WriteLine("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());


            if (input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else if (input % 2 == 1)
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
