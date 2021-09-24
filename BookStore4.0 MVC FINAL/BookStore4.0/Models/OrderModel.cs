using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore4._0.Models
{
    public class OrderModel
    {
        public int? customer_Id { get; set; }
        public int? book_Id { get; set; }
        public int? book_Price { get; set; }
        public DateTime? order_Time { get; set; }
        public int? total_Quantity { get; set; }
    }
}