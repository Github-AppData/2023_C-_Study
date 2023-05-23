using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class MyClassC
    {
        
        private int myField;

        // 일반적인 속성 생성 방법
        public int MyField
        {
            get { return myField; }
            set { myField = value; } // 'value' 라는 것을 생성을 하지 않았더라도 매개변수로 인식된다.
        }


    }
}
