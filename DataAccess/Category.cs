﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// lớp ánh xạ lớp category
    /// </summary>
    public class Category
    {
        // ID của bảng, tự tăng trong CSDL
        public int ID { get; set; }
        // Tên của loại thức ăn
        public string Name { get; set; }
        // Kiểu: 0 là đố uống; 1 là thức ăn...
        public int Type { get; set; }
    }
}
