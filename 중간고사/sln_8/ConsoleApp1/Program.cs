using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> lists = new List<int>() { 1, 2, 3, 4, 5 };
			lists.Add(4100); // 값 맨 마지막 인덱스에다가 추가
			lists.Remove(2); // 특정 값 삭제
			lists.RemoveAt(0); // 지정 인덱스 삭제
			lists.Insert(0, 2000); // 지정 인덱스에다가 값 삽입
			foreach (var item in lists)
			{
				Console.WriteLine("lists : {0}", item);
			}

			// 1. string 형식의 format 메서드
			Console.WriteLine("lists : {0}", "ss");

			// 2. 문자열 보간
			Console.WriteLine($"lists : {"asd"}");

			// 그 외에...
			Console.WriteLine("{0}, {1}", "First", "Second");

			// - : 왼쪽 정렬 / + : 오른쪽 정렬   10은 칸 수
			Console.WriteLine("Total : {0, -10:D}", 123);

			string fmt = "{0, -15}, {1, -20}, {2, -10}";
			Console.WriteLine(fmt, "Computer", "Hong Gildong", "Programing");

			Console.WriteLine("{0}", 123456789);
			Console.WriteLine("{0:N}", 123456789); // 입력된 수를 콤마로 구분하여 출력 - 소숫점 아래 자리까지.
			Console.WriteLine("{0:N0}", 123456789); // 입력된 수를 콤마로 구분하여 출력 
			Console.WriteLine("{0:F}", 123456789);

			double num = 3.142592;
			Console.WriteLine(num.ToString());
			Console.WriteLine(num.ToString("0.00"));
			Console.WriteLine(num.ToString("0.000"));


			// 동전 교환 프로그램
			Console.Write("금액을 입력해주세요 : ");
			int money = Convert.ToInt32(Console.ReadLine());

			int c500, c100, c50, c10;

			c500 = money / 500;
			money %= 500;

			c100 = money / 100;
			money %= 100;

			c50 = money / 50;
			money %= 50;

			c10 = money / 10;
			money %= 10;

			String[] Array = { "500원", "100원", "50원", "10원" };
			int[] sss = { c500, c100, c50, c10 };

			for (int i = 0; i < Array.Length; i++)
			{
				Console.WriteLine($"{Array[i]} => {sss[i]}");
			}
			Console.WriteLine($"바꾸지 못한 잔돈 {money}");


			// 사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성
			// - 입력 받은 년도를 12로 나눈 나머지를 사용한다. 나머지가 0,1,2,3,4,5,6,7,8,9,10,11
			// 일 때에 각각 원숭이, 닭, 개, 돼지, 소, 범, 토끼, 용, 뱀, 말, 양띠
			Console.WriteLine("띠를 구해드립니다. 다음 질문에 답하세요. ");
			Console.Write("당신은 몇년도 생인가요 ? : ");
			int birth_year = Convert.ToInt32(Console.ReadLine());
			int birth_years;
			String belt = " ";

			birth_years = birth_year % 12;

			switch (birth_years)
			{
				case 0:
					belt = "원숭이";
					break;
				case 1:
					belt = "닭";
					break;
				case 2:
					belt = "개";
					break;
				case 3:
					belt = "돼지";
					break;
				case 4:
					belt = "쥐";
					break;
				case 5:
					belt = "소";
					break;
				case 6:
					belt = "범";
					break;
				case 7:
					belt = "토끼";
					break;
				case 8:
					belt = "용";
					break;
				case 9:
					belt = "뱀";
					break;
				case 10:
					belt = "말";
					break;
				case 11:
					belt = "양";
					break;
			}

			Console.Write($"{birth_year}인 당신은 {belt}띠 입니다.");


			// 달을 입력받아, 계절을 뱉는 프로그램
			Console.Write("현재 월을 입력하세요(1~12):");
			int month = int.Parse(Console.ReadLine());

			string season;
			switch (month)
			{
				case 12:
				case 1:
				case 2:
					season = "겨울";
					break;
				case 3:
				case 4:
				case 5:
					season = "봄";
					break;
				case 6:
				case 7:
				case 8:
					season = "여름";
					break;
				case 9:
				case 10:
				case 11:
					season = "가을";
					break;
				default:
					season = "잘못된 입력입니다.";
					break;
			}
			Console.WriteLine($"입력하신 {month}월의 계절은 {season}입니다.");

			// 가운데 피라미드 만드는 방법
			// j는 점차 감소, k는 점차증가
			for (int i = 0; i < 10; i++)
			{
				for (int j = 9; j >= i; j--)
				{
					Console.Write(" ");
				}
				for (int k = 0; k < i * 2 + 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			// 왼쪽 직각 삼각형 만드는 방법
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			// 오른쪽 직각 삼각형 만드는 방법
			// j는 점차 감소, k는 점차 증가
			for (int i = 0; i < 10; i++)
			{
				for (int j = 9; j >= i; j--)
				{
					Console.Write("*");
				}
				for (int k = 0; k <= i; k++)
				{
					Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}
