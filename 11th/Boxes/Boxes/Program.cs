using System;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxA ba = new BoxA(32, 22);
            Console.WriteLine(ba.Area());

            Console.WriteLine();

            BoxB bb = new BoxB(-32, 22);
            Console.WriteLine(bb.Area());

            /*BoxB.width = -10;*/ // private로 필드를 지정하면, 직접 접근을 못한다.

            BoxC bc = new BoxC(-32, 22);
            Console.WriteLine(bc.Area());





        }
    }
}
