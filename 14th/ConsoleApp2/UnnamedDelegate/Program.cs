using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedDelegate
{
	class Program
	{
		
		class Product
		{
			public string Name { get; set; }
			public int Price { get; set; }
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

			// 델리게이터를 좀 더 편하게 사용할 때는 람다.
			// 델리게이터를 간단하고 편리하게, 매개변수의 자료형을 지정할 필요 없다.

			// 무명 델리게이트로 정렬 방법 정의
			// 무명 이지만, 메서드 형식을 갖추고 있다.
			/*products.Sort(
				delegate (Product a, Product b)
				{
					return a.Price.CompareTo(b.Price);
				}
				);*/

			// Sort() 메서드의 매개 변수로 람다를 지정
			products.Sort((a, b) => a.Price.CompareTo(b.Price));


			// 출력
			foreach (var item in products)
			{
				Console.WriteLine(item.Name + " : " + item.Price);
			}
		}
	}
}
