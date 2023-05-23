using System;

namespace project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* MyClassA Aobj = new MyClassA();
             Aobj.myField = 1212;
             Console.WriteLine(Aobj.myField);

             MyClassB Bobj = new MyClassB();
             Bobj.SetMyField(12);
             Console.WriteLine(Bobj.GetMyField());

            MyClassC Cobj = new MyClassC();
            Cobj.MyField = 30;
            Console.WriteLine(Cobj.MyField);*/

            MyClassD Dobj = new MyClassD();
            Dobj.MyField = 10000000;
            Console.WriteLine(Dobj.MyField);
        }
    }
}
