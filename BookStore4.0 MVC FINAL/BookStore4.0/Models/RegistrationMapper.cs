using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore4._0.Models
{
    public class RegistrationMapper
    {
        public static BookStore4._0.Models.Registration Map(Data.Entities.customer cust)
        {
            return new BookStore4._0.Models.Registration()
            {
                Name = cust.customer_Name,
                Email = cust.customer_Email,
                Age = cust.customer_Age,
                Phone = cust.customer_Phone,
                Address = cust.customer_Address,
                Password = cust.customer_Password,
                Gender = cust.customer_Gender,
            };
        }
        public static Data.Entities.customer Maps(BookStore4._0.Models.Registration reg)
        {
            return new Data.Entities.customer()
            {
                customer_Name = reg.Name,
                customer_Email = reg.Email,
                customer_Age = reg.Age,
                customer_Phone = reg.Phone,
                customer_Address = reg.Address,
                customer_Password = reg.Password,
                customer_Gender = reg.Gender,
            };
        }
        
        public static Data.Entities.customer_Order_History orderMap(int customer_Id,int book_Id,int total_price,DateTime Time,int quantity)
        {
            return new Data.Entities.customer_Order_History()
            {
                customer_Id = customer_Id,
                book_Id = book_Id,
                total_Price = total_price,
                order_Time = Time,
                total_Quantity =quantity,
            };
        }

    }
}