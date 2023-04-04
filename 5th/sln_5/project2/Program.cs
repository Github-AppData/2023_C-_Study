using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 논리연산자와 조건문
            /* Console.Write("학점을 입력하세요. : ");
             double score = Convert.ToDouble(Console.ReadLine());*/

            /* if (score == 4.5) { Console.WriteLine("최우수"); }
             else if (4.0 <= score && score < 4.5) { Console.WriteLine("우수"); }
             else if (3.5 <= score && score < 4) { Console.WriteLine("아주잘함"); }
             else if (3 <= score && score < 3.5) { Console.WriteLine("잘함"); }
             else if (2.5 <= score && score < 3) { Console.WriteLine("보통잘함"); }
             else if (2 <= score && score < 2.5) { Console.WriteLine("보통"); }
             else if (1.5 <= score && score < 2) { Console.WriteLine("분발"); }
             else if (1 <= score && score < 1.5) { Console.WriteLine("많이 분발"); }
             else { Console.WriteLine("다음 학기 때 또 보자"); }*/

            /*Console.Write("tntwkasjhdouash. : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num > 0 ? "자연수" : "자연수 아닙니다.");*/

            Console.WriteLine("이번 달은 몇 월 인가요 : ");
            int input = Convert.ToInt32(Console.ReadLine());

        /*    switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 이군요");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름이군요");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 이군요");
                    break;

                default:
                    Console.WriteLine("뭐야 너 지구인 아니지");
                    break;
            }*/

            if (input == 12 || input == 1 || input == 2)
            {
                Console.WriteLine("겨울 이군요");
            }
            else if (input == 9 || input == 10 || input == 11)
            {
                Console.WriteLine("가을 이군요");
            }
            else if (input == 3 || input == 4 || input == 5)
            {
                Console.WriteLine("봄 이군요");
            }
            else if (input == 6 || input == 7 || input == 8)
            {
                Console.WriteLine("여름 이군요");
            }
            else { Console.WriteLine("나가"); }
        }
    }
}
