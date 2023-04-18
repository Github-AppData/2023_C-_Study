using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 중첩 for문 구구단
            /*for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("{0} 단\n", i);

                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }

                Console.WriteLine();
            }*/

            // 중첩 while문 구구단
            /*int dan = 2, cnt = 1;

            while (dan <= 9)
            {
                Console.WriteLine("{0}단", dan);
                while (cnt <= 9)
                {
                    Console.WriteLine("{0} * {1} = {2}", dan, cnt, cnt * dan);
                    cnt++;
                    if (cnt == 10)
                    {
                        dan += 1;
                    }
                }
                cnt = 1;
                Console.WriteLine();
            }*/

            // 중간 시험문제 - 별 왼쪽에 붙은 직각 삼각형
            /* for(int i = 0; i < 10; i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }

             // 중간 시험문제 - 별 피라미드 (가운데)
             for (int i = 0; i < 10; i++) // i는 전체 행의 갯수
             {
                 for (int j = 9; j >= i; j--) // 
                 {
                     Console.Write(" ");
                 }
                 for (int j = 0; j < i * 2 + 1; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/

            // 중간 시험문제 - 별 오른쪽에 붙은 직각 삼각형
            /*for (int i = 0; i < 5; i++) // i는 전체 행의 갯수
            {
                for (int j = 0;  j < 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/


            // 
            int i, j, sp = 8;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= sp; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i ; j++)
                {
                    /*Console.Write(i + "");*/
                    Console.Write(i + " ");
                    /*Console.Write(""+i);*/
                    /*Console.Write(" " + i);*/
                }
                Console.WriteLine();
                sp--;
            }

        }
    }
}
