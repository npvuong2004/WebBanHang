﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string KhachHangName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Total { get; set; }
        public string State { get; set; }

    }
}
