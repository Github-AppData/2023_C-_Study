using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxE
    {
        // 12주차 공부

        // 필드 변수
        private int width; 
        private int height;

        public int Height // 속성 - private 필드 값에 접근할 수 있는 것이다.
        {
            // get - return이 있어야 한다. 
            // set - value라는 키워드가 필요하다.
            get; set;
        }

        public int Width { get; set; }
        

        public int Area() { return Width * Height; } // 속성 값으로 계산 (필드 변수 값으로 계산 하는 것이 아니다.)

        public BoxE(int width, int height)
        {
            Width = width; // 속성으로 접근해야 한다. - 필드로 접근하는 것이 아니다.
            Height = height; // 속성으로 접근해야 한다. - 필드로 접근하는 것이 아니다.
        }
    }
}
