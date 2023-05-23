using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxD
    {
        // 12주차 공부
        private int width; // 필드 변수
        public int Height // 속성
        {
            // get - return이 있어야 한다. 
            // set - value라는 키워드가 필요하다. => 원래는 height = value; 이것만 있으면 되는데, 상황에 따라 조건을 추가한 것이다.
            get { return height;  }
            set { 
                if (value > 0) 
                { height = value; }
                else
                { Console.WriteLine("높이는 자연수를 입력해주세요. "); }
            }
            
        }

        public int Width
        {
            get { return width; } // get 반드시 return
            set // rl
            {
                if (value > 0) { width = value; } // value: 매개변수와 같은 기능을 하는 것 (= 키워드)
                else { Console.WriteLine("너비는 자연수를 입력해주세요. "); }
            }
        }
        private int height;

        public int Area() { return Width * Height; } // 속성 값으로 계산 (필드 변수 값으로 계산 하는 것이 아니다.)

        public BoxD(int width, int height)
        {
            Width = width; // 속성으로 접근해야 한다. - 필드로 접근하는 것이 아니다.
            Height = height; // 속성으로 접근해야 한다. - 필드로 접근하는 것이 아니다.
        }

    }
}
