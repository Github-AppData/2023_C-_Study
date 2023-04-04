using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// if 조건문
            Console.Write("숫자를 입력하세요 : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input);

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수라고");
            }
            else
            {
                Console.WriteLine("홀수라고");
            }*/

            /*if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else if(DateTime.Now.Hour > 12)
            {
                Console.WriteLine("오후 입니다.");
            }*/


            /*if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }*/

            /*// if else if 조건문
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }*/

            Console.Write("금액을 입력하세요 : ");
            int my_money = Convert.ToInt32(Console.ReadLine());

            if (my_money >= 20000) { Console.WriteLine("깐쇼새우"); }
            else if (my_money >= 10000) { Console.WriteLine("미니 탕수육"); }
            else if (my_money >= 7000) { Console.WriteLine("짬뽕"); }
            else if (my_money >= 6000) { Console.WriteLine("짜장면"); }
            else { Console.WriteLine("단무지 먹고 튄다."); }



        }
    }
}
