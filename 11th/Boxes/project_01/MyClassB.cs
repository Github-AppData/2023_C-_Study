using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class MyClassB
    {
        private int myField; // 필드 (변수)

        // 메소드를 통하여 private 변수에 접근
        public int GetMyField() { return myField; } // 겟터
        public void SetMyField(int value) { myField = value; } // 셋터



        // 속성을 통하여 private 변수에 접근
        /*public int MyField
        {
            get;
            set;
        }*/
    }
}
