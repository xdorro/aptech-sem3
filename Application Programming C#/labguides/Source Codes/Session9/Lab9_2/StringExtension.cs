﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_2
{
    //Định nghĩa lớp tĩnh
    public static class StringExtension
    {
        //định nghĩa phương thức mở rộng cho lớp String để đếm số từ của một chuỗi 
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
