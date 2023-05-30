using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Child : Parent
    {
        // base(매개변수) : 부모 생성자를 먼저 참조하겠습니다. ★★★★★
        public Child() : base() 
        {
            Console.WriteLine("자식 생성자");
        }
    }
}
