using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "왜 살아야 하는가 ? ";
            book.publisher = "sss";
            book.Write = "ssss";

            Console.WriteLine(book.title + "\n" + book.Write + "\n" + book.publisher);
            Console.WriteLine();

            product pro = new product();

            pro.name = "호박";
            pro.price = 30000;

            Console.WriteLine(pro.name + "\n" + pro.price);
            Console.WriteLine();

            product proA = new product() { name = "짜장면", price = 7000 };
            product proB = new product() { name = "짬뽕", price = 8000 };
            product proC = new product() { name = "탕수육", price = 13000 };
            product proD = new product() { name = "군만두", price = 6900 };

            Console.WriteLine(proA.name + proA.price);
            Console.WriteLine(proB.name + proB.price);
            Console.WriteLine(proC.name + proC.price);
            Console.WriteLine(proD.name + proD.price);

            // 클래스 변수나 메서드는 인스턴스를 생성하는 것이 아니다.
            /*MyMath math = new MyMath();*/
            Console.WriteLine(MyMath.PI);

            Car car = new Car();
            car.Hi();
            car.Go();
        }
    }
}
