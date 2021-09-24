using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore4._0.Models
{
    public class CustomerMapper
    {
        public static BookStore4._0.Models.customer Map(Data.Entities.customer cust)
        {
            return new BookStore4._0.Models.customer()
            {
                Id = cust.customer_Id,
                Name = cust.customer_Name,
                Email = cust.customer_Email,
                Age = cust.customer_Age,
                Phone =cust.customer_Phone,
                Address = cust.customer_Address,
                Gender = cust.customer_Gender
            };
        }
        public static BookStore4._0.Models.OrderModel orderMap(Data.Entities.customer_Order_History cust)
        {
            return new BookStore4._0.Models.OrderModel()
            {
                customer_Id = cust.customer_Id,
                book_Id = cust.book_Id,
                book_Price = cust.total_Price,
                order_Time = cust.order_Time,
                total_Quantity = cust.total_Quantity


            };
        }
        public static Data.Entities.cart AddMap(BookStore4._0.Models.AddCartModel cart)
        {
            return new Data.Entities.cart()
            {
                customer_Id = cart.customer_Id,
                book_Id = cart.book_Id,
                book_Quantity = cart.book_Quantity
               
            };
        }
        public static Data.Entities.bookDetail booksMap(BookStore4._0.Models.BokkDetailsModel book)
        {
            return new Data.Entities.bookDetail()
            {
        
                book_Id = book.book_Id,
                book_Name = book.book_Name,
                book_Author = book.book_Author,
                book_Price = book.book_Price,
                book_Quantity = book.book_Quantity,
                book_Category_id = book.book_Category

            };
        }
        public static Data.Entities.bookDetail booksMap2(BookStore4._0.Models.BookModel book)
        {
            return new Data.Entities.bookDetail()
            {

                book_Id = book.book_Id,
                book_Name = book.book_Name,
                book_Author = book.book_Author,
                book_Price = book.book_Price,
                book_Quantity = book.book_Quantity,
                book_Category_id = book.book_Category

            };
        }
        public static Data.Entities.bookDetail booksMap1(BookStore4._0.Models.BokkDetailsModel book)
        {
            return new Data.Entities.bookDetail()
            {

                
                book_Name = book.book_Name,
                book_Author = book.book_Author,
                book_Price = book.book_Price,
                book_Quantity = book.book_Quantity,
                book_Category_id = book.book_Category

            };
        }
        public static BookStore4._0.Models.Login LoginMap(Data.Entities.customer cust)
        {
            return new BookStore4._0.Models.Login()
            {
              
                Email = cust.customer_Email,
                Password = cust.customer_Password,
            };
        }

        public static BookStore4._0.Models.BokkDetailsModel bookMap(Data.Entities.bookDetail bd)
        {
            return new BookStore4._0.Models.BokkDetailsModel()
            {
                book_Id = bd.book_Id,

                book_Name = bd.book_Name,

                book_Author = bd.book_Author,

                book_Price = bd.book_Price,

                book_Quantity = bd.book_Quantity,

                book_Category = bd.book_Category_id,


            };
        }
        public static BookStore4._0.Models.BookModel bookMap3(Data.Entities.bookDetail bd)
        {
            return new BookStore4._0.Models.BookModel()
            {
              
                book_Id =bd.book_Id,

                book_Name = bd.book_Name,

                book_Author = bd.book_Author,

                book_Price = bd.book_Price,

                book_Quantity = bd.book_Quantity,

                book_Category = bd.book_Category_id,


            };
        }
        public static BookStore4._0.Models.cartModel bookMap1(Data.Entities.bookDetail bd)
        {
            return new BookStore4._0.Models.cartModel()
            {
                book_Id = bd.book_Id,

                book_Name = bd.book_Name,

                book_Author = bd.book_Author,

                book_Price = bd.book_Price,

                book_Category = bd.book_Category_id,


            };
        }
    }
}