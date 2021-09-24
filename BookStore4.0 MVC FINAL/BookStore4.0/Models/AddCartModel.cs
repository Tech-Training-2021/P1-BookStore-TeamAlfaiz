using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore4._0.Models
{
    public class AddCartModel
    {
        public int? customer_Id { get; set; }
        public int? book_Id { get; set; }
        public int? book_Quantity { get; set; }
    }
}