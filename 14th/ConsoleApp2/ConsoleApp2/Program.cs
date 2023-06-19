using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		
		class Product
		{
			public string Name { get; set; }
			public int Price { get; set; }
		}

		// 델리게이트 실습 - 1. 정렬 
		// 가격으로 정렬 하겠다.
		static int SortWithPrice(Product a, Product b)
		{
			// a와 b 상품의 가격을 비교를 해서 리턴을 하겠다.
			// CompareTo는 메서드가 아니라 딜리게이터
			return a.Price.CompareTo(b.Price); 
		}


		static void Main(string[] args)
		{
			// List를 생성 
			List<Product> products = new List<Product>() 
			{ 
				new Product() {Name = "감자", Price = 5000},
				new Product() {Name = "감자2", Price = 1000},
				new Product() {Name = "감자3", Price = 2000},
				new Product() {Name = "감자4", Price = 3000}
			};

			// 정렬
			products.Sort(SortWithPrice);

			// 출력
			foreach (var item in products)
			{
				Console.WriteLine(item.Name + " : " + item.Price);
			}
		}
	}
}
