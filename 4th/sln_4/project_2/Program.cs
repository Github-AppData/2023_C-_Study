using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 동전 교환 프로그램
            int money;
            int c500, c100, c50, c10;

            Console.Write("교환할 돈을 입력하세요. : ");
            money = Convert.ToInt32(Console.ReadLine());

            c500 = money / 500;
            money %= 500;

            c100 = money / 100;
            money %= 100;

            c50 = money / 50;
            money %= 50;

            c10 = money / 10;
            money %= 10;

            Console.WriteLine("\n500원 => " + c500 + "개");
            Console.WriteLine("100원 => " + c100 + "개");
            Console.WriteLine("50원 => " + c50 + "개");
            Console.WriteLine("10원 => " + c10 + "개\n");
            Console.WriteLine("바꾸지 못한 잔돈 => " + money + "원");      

        }
    }
}
