using System;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BoxA ba = new BoxA(32, 22);
            Console.WriteLine(ba.Area());

            Console.WriteLine();

            BoxB bb = new BoxB(-32, 22);
            Console.WriteLine(bb.Area());

            BoxB.width = -10; // private로 필드를 지정하면, 직접 접근을 못한다.

            BoxC bc = new BoxC(-32, 22);
            Console.WriteLine(bc.Area());*/

            /*// 12주차 공부  - BoxD.cs
            BoxD boxD = new BoxD(12,12); // 자연수가 아니면, 결과 값이 출력이 되지 않는다.
            Console.WriteLine(boxD.Width); // 속성에 접근한다.
            Console.WriteLine(boxD.Height);
            Console.WriteLine(boxD.Area());*/

            // 12주차 공부  - BoxE.cs
            BoxE boxE = new BoxE(-12, 12); // 자연수가 아니면, 결과 값이 출력이 되지 않는다.
            Console.WriteLine(boxE.Width); // 속성에 접근한다.
            Console.WriteLine(boxE.Height);
            Console.WriteLine(boxE.Area());










        }
    }
}
