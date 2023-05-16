using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxC
    {
        // 겟터와 셋터 : 변수를 바로 수정할 수는 없지만 변수를 변경하는 메서드를 만들고,
        // 메세드를 호출해서 변경

        private int width;
        private int height;

        public int Area() { return this.width * this.height; }

        public BoxC (int width, int height)
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화 해주세요.");
            }
        }

        public int GetWidth() { return width; }
        public int GetHeight() { return height; }

        public void SetWidth() 
        {
            if (width > 0) { this.width = width; } 
            else { Console.WriteLine("너비는 자연수를 입력해 주세요.");}

        }
        public void SetHeight()
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("너비는 자연수를 입력해 주세요."); }

        }







    }
}
