using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***암기 해야 한다. 3가지 키워드 전부 다 (차이점 포함)***/
            
            // 상속 : 부모클래스를 만들어 둠으로써, 자식 클래스들의 메소드 코드 중복을 해결한다.
            List<Dogs> dogs = new List<Dogs>() { new Dogs(), new Dogs(), new Dogs() };
            List<Cats> cats = new List<Cats>() { new Cats(), new Cats(), new Cats() };

            // 원소를 참조해서 출력
            /*foreach (var item in dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            Console.WriteLine();

            foreach (var item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }*/

            // 메인의 17 ~ 31줄의 중복되는 코드들을 간단하게 작성할 수는 없을까 ? - 다형성
            // 다형성 : 메인에서 동작하는 중복된 코드들을 간략화 하는 것을 '다형성' 이라고 한다.
            // 외형적으로는 부모 클래스지만, 실제적으로는 자식클래스로 결과를 내는 것이다.
            List<Animal> animals = new List<Animal>()
            {
                new Dogs(), new Cats(),new Dogs(), new Cats(),
                new Dogs(), new Cats(),new Dogs(), new Cats()
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();

                // 일반적인 자료형 변환
                // is : 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool로 변환 
                /* if (item is Dogs) 
                 { 
                     ((Dogs)item).Bark();  
                 }

                 if(item is Cats)
                 {
                     ((Cats)item).Meow();
                 }
                 Console.WriteLine("-------");*/


                //// as 키워드를 이용한 자료형 변환
                // as : 형식 변환 연산자와 같은 역할을 한다. - 연산자

                // is 와 as 키워드의 차이점
                //: as는 성공하면 캐스팅의 결과를 리턴 실패하면, Null
                // is는 성공하면, is는 true, false이다.

                // as 키워드를 가지고 작성하는 것이 효율적이다.
                // 단, Null 값이 안 나오는 전제조건 하에... 
                /*if (item is Dogs)
                {
                    (item as Dogs).Bark();
                }

                if (item is Cats)
                {
                    (item as Cats).Meow();
                }*/
                /*Console.WriteLine("--------");*/

                // as 키워드를 사용하는 경우의 일반적인 형태 - ★★★★★
                
                // dog는 부모 클래스인 Animal의 정보도 가지고 있지만,
                // 자식 클래스인 Dogs의 정보도 가지고 있다.
                var dog = item as Dogs;
                if(dog != null)
                {
                    dog.Bark();
                }

                var cat = item as Cats;
                if (cat != null)
                {
                    cat.Meow();
                }
                Console.WriteLine("--------");
            }


        }
    }
}
