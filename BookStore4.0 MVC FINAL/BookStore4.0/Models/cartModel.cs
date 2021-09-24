using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore4._0.Models
{
    public class cartModel
    {
        public int book_Id { get; set; }
        public string book_Name { get; set; }
        public string book_Author { get; set; }
        public int book_Price { get; set; }
        public int book_Category { get; set; }
    }
}