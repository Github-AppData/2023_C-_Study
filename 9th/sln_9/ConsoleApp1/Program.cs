using System;

namespace ConsoleApp1
{
    class Program
    {
        class book
        {
            public string Title;
            public string writer;
            public string publishier;
            public int published_date;
            public string content;
        }

        class product
        {
            public int price;
            public string name;
        }

        static void Main(string[] args)
        {
            // 클래스 사용 방법
            /*book b1 = new book(); // Book 설계도로 부터 Book1 객체
            b1.Title = "C# Programing";
            b1.writer = "홍길동";
            b1.publishier = "(도)유한";
            b1.published_date = 20230502;
            b1.content = "실습 열심히 하자";

            Console.WriteLine($"제목 : {b1.Title}");
            Console.WriteLine($"저자 : {b1.writer}");
            Console.WriteLine("출판사 : {0}", b1.publishier);
            Console.WriteLine($"출판 일 : {b1.published_date}");
            Console.WriteLine($"내용 : {b1.content}");

            Console.WriteLine();

            book b2 = new book(); // Book 설계도로 부터 Book1 객체
            b2.Title = "Java Programing";
            b2.writer = "히길동";
            b2.publishier = "(도)유한";
            b2.published_date = 20230502;
            b2.content = "Java King";

            Console.WriteLine($"제목 : {b2.Title}");
            Console.WriteLine($"저자 : {b2.writer}");
            Console.WriteLine("출판사 : {0}", b2.publishier);
            Console.WriteLine($"출판 일 : {b2.published_date}");
            Console.WriteLine($"내용 : {b2.content}");
*/
            product p1 = new product();

            p1.name = "초콜릿 바";
            p1.price = 1000;

            Console.WriteLine($"상품 이름 : {p1.name}");
            Console.WriteLine($"가격 : {p1.price}원");

            Console.WriteLine();

            product p2 = new product();

            p2.name = "쌀 20KG";
            p2.price = 50000;

            Console.WriteLine($"상품 이름 : {p2.name}");
            Console.WriteLine("가격 : {0}원", p2.price);

            Console.WriteLine();

            product p3 = new product() { name = "감자", price = 2000};
            product p4 = new product() { name = "고구마", price = 7000 };
            product p5 = new product() { name = "토마토", price = 3000 };

            Console.WriteLine($"상품 이름 : {p3.name}");
            Console.WriteLine("가격 : {0}원", p3.price);

            Console.WriteLine();

            Console.WriteLine($"상품 이름 : {p4.name}");
            Console.WriteLine("가격 : {0}원", p4.price);

            Console.WriteLine();

            Console.WriteLine($"상품 이름 : {p5.name}");
            Console.WriteLine("가격 : {0}원", p5.price);

        }
    }
}
