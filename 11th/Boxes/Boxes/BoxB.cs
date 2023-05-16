﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxB
    {
        // 캡슐화 : 변수 너비와 높이를 건드리지 못하게 막음.
        private int width;
        private int height;

        public int Area() // 메서드 정의
        {
            return this.width * this.height;
        }

        public BoxB(int width, int height) // 생성자 정의
        {
            this.width = width;
            this.height = height;
        }
    }
}
