using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class customerRepo 
    {
        private Model1 db;
        public customerRepo(Model1 db)
        {
            this.db = db;
        }
        public IEnumerable<customer> GetCustomer()
        {
            return db.customers.ToList();
        }
        public List<customer_Order_History> getorderHistoryById(int id)
        {
            var order_History = db.customer_Order_History.Where(c => c.customer_Id == id).ToList();
            return order_History;
        }
        public IEnumerable<customer_Order_History> customer_Order_Histories()
        {
            return db.customer_Order_History.ToList();
        }
        public customer GetCustomerById(int id)
        {
            var customer = db.customers.Where(c => c.customer_Id == id).FirstOrDefault(); 
            return customer;

        }
        public bookDetail GetBookById(int id)
        {
            var book = db.bookDetails.Where(c => c.book_Id == id).FirstOrDefault();
            return book;

        }
        public customer LoginCustomer(string Email,String Password)
        {
           var login =  db.customers.Where(c => c.customer_Email == Email && c.customer_Password == Password).FirstOrDefault();
            return login;
        }
        public void AddCustomer(customer cust)
        {
            db.customers.Add(cust);
            Save();
        }

        public void DeleteProduct(int id,int userid)
        {
            var data = db.carts.Where(d => d.book_Id == id && d.customer_Id==userid).FirstOrDefault();
            if (data != null)
            {
                db.carts.Remove(data);
                Save();
            }
            else
                throw new ArgumentException("customer not found");
        }
    
        public void DeleteCart(int id)
        {
            var data = db.carts.Where(d =>  d.customer_Id == id).ToList();
            var count = data.Count;
            if (data != null)
            {
                for(int i=0;i<count;i++)
                {
                    db.carts.Remove(data[i]);
                    Save();
                }
                
            }
        }
        //update quantity 
        
        public void UpdateQuantity(int id) { 
        var custEdit = db.bookDetails.Where(m => m.book_Id== id).FirstOrDefault();
            if (custEdit != null)
            {
                custEdit.book_Quantity = ((custEdit.book_Quantity) - 1);
                Save();
            }
        }
        //get customer by name
        public IEnumerable<customer> getcustomerbyName(string name)
        {
            return db.customers.Where(m => m.customer_Name == name).ToList();
        }
        //update book details
        public void UpdateBooks(bookDetail book)
        {
            var custEdit = db.bookDetails.Where(m => m.book_Id == book.book_Id).FirstOrDefault();
            if (custEdit != null)
            {
                custEdit.book_Name = book.book_Name;
                custEdit.book_Author = book.book_Author;
                custEdit.book_Price = book.book_Price;
                custEdit.book_Quantity = book.book_Quantity;
                custEdit.book_Category_id = book.book_Category_id;
                Save();
            }
        }
        public IEnumerable<bookDetail> GetbookDetail()
            {
                return db.bookDetails
                        .ToList();
            }
        public IEnumerable<category> GetCategories()
        {
            return db.categories
                    .ToList();
        }
        //cart details
        public IEnumerable<bookDetail> GetcartDetail(int userid)
            {
                var li = new List<bookDetail>();
                var books =  db.carts.Where(c => c.customer_Id ==userid).ToList();
                foreach(var b in books)
                {
                   li.Add( db.bookDetails.Where(c => c.book_Id == b.book_Id).FirstOrDefault());
                }
                return li;
            }

            public string GetCategoryDetail(int id)
            {
           
                return db.categories.Where(c => c.category_id == id).Select(c => c.book_category).FirstOrDefault().ToString();
            }
            public int Cartinornot(int id)
            {
                var a = db.carts.Where(c => c.book_Id == id).FirstOrDefault();
                int b = 0;
                if (a != null)
                {
                    b = 1;
                    return b;
                }
                else
                {
                    b = 2;
                    return b;
                }
            }
            public void AddtoCart(cart cat)
            {
                db.carts.Add(cat);
                Save();
            }
            public void AddtoOrder(customer_Order_History od)
            {
                db.customer_Order_History.Add(od);
                Save();
            }
            public void AddBook(bookDetail book)
                {
                    db.bookDetails.Add(book);
                    Save();
                }
            public void Save()
            {
                db.SaveChanges();
            }
        
        }
}
