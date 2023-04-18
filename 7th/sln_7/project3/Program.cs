using System;
using System.Threading;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while(!false)
            {
                Console.Write("숫자를 입력해주세요 (짝 = 종료): ");
                int input = Convert.ToInt32(Console.ReadLine());
                *//*if(input % 2 == 1)*//*
                if(input % 2 != 0)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break; // 실행을 종료해주세요.
                }
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue; // 반복을 멈추고 찍어주세요. - 한번 건너뛰어주세요.
                }

                *//*Console.WriteLine(i);*//*
                Console.WriteLine($"{i} : 홀수"); // 문자열 보간
            }*/

            // Thread.Sleep() 메서드
            Console.WriteLine("첫 번째 출력 : ");
            Thread.Sleep(1500); // 1.5s
            Console.WriteLine("두 번째 출력 : ");
            Thread.Sleep(1500); // 1.5s
            Console.WriteLine("세 번째 출력 : ");
            


        }
    }
}
