using System.Collections.Generic;
using System.Web.Mvc;
using System.Web;
using System.Linq;
using System;
using Data.Entities;
using Data;
using BookStore4._0.Models;
namespace BookStore4._0.Controllers
{

    public class BookController : Controller
    {
        // GET: Book
       customerRepo repo ;
     
       public BookController()
        {
            repo = new customerRepo(new Model1());
        }
        [Authorize]
        public ActionResult Index()
        {
            var ab = Request.Cookies["User_id"].Value.ToString();
            ViewBag.v = ab;
            var customer = repo.GetCustomer();
            var data = new List<BookStore4._0.Models.customer>();
            foreach(var c in customer)
            {
                data.Add(CustomerMapper.Map(c));
            }
            return View(data);
        }
        [Authorize]
        public ActionResult GetCustomerById(int id)
        {
            var customer = repo.GetCustomerById(id);
            return View(CustomerMapper.Map(customer));
        }
        [Authorize]
        public ActionResult GetBookById(int id)
        {
            ViewBag.Category = new SelectList(repo.GetCategories(), "category_id", "book_category"); 
            var book = repo.GetBookById(id);
            return View(CustomerMapper.bookMap3(book));
        }
        [Authorize]
        [HttpPost]
        public ActionResult UpdateBookDetails(BookModel model)
        {
            repo.UpdateBooks(CustomerMapper.booksMap2(model));
            return RedirectToAction("getBookDetails1");
        }
        //Profile Details
        [Authorize]
        public ActionResult profileDetails(int id)
        {
            var customer = repo.GetCustomerById(id);
            return View(CustomerMapper.Map(customer));
        }
     
        public ActionResult AddCustomer()
        {
            //Models.Registration obj = new Models.Registration();
            return View();
        }
        
        [HttpPost]
        public ActionResult AddCustomer(Registration reg)
        {
            if (ModelState.IsValid)
            {
                repo.AddCustomer(RegistrationMapper.Maps(reg));
                return RedirectToAction("Index");
            }
            return View(reg);
        }

        //get book details
        [Authorize]
        public ActionResult getBookDetails()
        {
            
            var bookDetails = repo.GetbookDetail();
            var category_name = new List<string>();
            var check = new List<int>();
            var data = new List<BookStore4._0.Models.BokkDetailsModel>();
            foreach(var c in bookDetails)
            {
                string categoryname = repo.GetCategoryDetail(c.book_Category_id);
                category_name.Add(categoryname);
                int checkin = repo.Cartinornot(c.book_Id);
                check.Add(checkin);
                data.Add(CustomerMapper.bookMap(c));
            }
            ViewBag.Check = check;
            ViewBag.Cat = category_name;
            return View(data);
        }
        [Authorize]
        public ActionResult getBookDetails1()
        {

            var bookDetails = repo.GetbookDetail();
            var category_name = new List<string>();
            var check = new List<int>();
            var data = new List<BookStore4._0.Models.BokkDetailsModel>();
            foreach (var c in bookDetails)
            {
                string categoryname = repo.GetCategoryDetail(c.book_Category_id);
                category_name.Add(categoryname);
                int checkin = repo.Cartinornot(c.book_Id);
                check.Add(checkin);
                data.Add(CustomerMapper.bookMap(c));
            }
            ViewBag.Check = check;
            ViewBag.Cat = category_name;
            return View(data);
        }
        //SHOW CART
        [Authorize]
        public ActionResult getCartDetails(int id)
        {
            var bookDetails = repo.GetbookDetail();
            var cartDetails = repo.GetcartDetail(id);
            var data = new List<BookStore4._0.Models.cartModel>();
            var category_name = new List<string>();
            var Total = 0;
            foreach (var e in cartDetails)
            {
                data.Add(CustomerMapper.bookMap1(e));
            }
            foreach (var c in cartDetails)
            {
                foreach(var b in bookDetails)
                {
                    if (b.book_Id == c.book_Id)
                    {
                        Total = Total + b.book_Price;
                        string categoryname = repo.GetCategoryDetail(b.book_Category_id);
                        category_name.Add(categoryname);
                    }
                }
            }
            ViewBag.Total = Total;
            ViewBag.cat = category_name;
            return View(data);
        }
        //FROM CART TO ORDER
        [Authorize]
        public JsonResult AddtoOrder(int userid,DateTime dateTime)
        {
            var cart = repo.GetcartDetail(userid);
            var book_quantity = 1;
            foreach(var v in cart)
            {
                repo.AddtoOrder(RegistrationMapper.orderMap(userid,v.book_Id,v.book_Price,dateTime,book_quantity));
                repo.UpdateQuantity(v.book_Id);
            }
            repo.DeleteCart(userid);
            return Json("true", JsonRequestBehavior.AllowGet);
           
        }
        [Authorize]
        public JsonResult BuyNow(int userid, DateTime dateTime,int book_Id,int book_Price)
        {
                var book_quantity = 1;  
                repo.AddtoOrder(RegistrationMapper.orderMap(userid, book_Id,book_Price, dateTime, book_quantity));
                repo.UpdateQuantity(book_Id);
                return Json("true", JsonRequestBehavior.AllowGet);

        }
        [Authorize]
        public JsonResult AddtoCart(AddCartModel addcart)
        {
             repo.AddtoCart(CustomerMapper.AddMap(addcart));
             return Json("true", JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        public JsonResult deleteCart(int id,int userid)
        {
            repo.DeleteProduct(id,userid);
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        public ActionResult CustomerOrderHistory()
        {
            var customerorderhistory = repo.customer_Order_Histories();
            var books = new List<string>();
            var data = new List<BookStore4._0.Models.OrderModel>();
            foreach(var c in customerorderhistory)
            {
                var book = repo.GetBookById(Convert.ToInt32(c.book_Id));
                data.Add(CustomerMapper.orderMap(c));
                books.Add(book.book_Name);
            }
            ViewBag.BookName = books;
            return View(data);
        }
        [Authorize]
        public ActionResult getcustomerbyName(string name)
        {
            var category = new List<string>();
            var data1 = new List<BookStore4._0.Models.customer>();
            var books = new List<BookStore4._0.Models.BokkDetailsModel>();
            var order = new List<BookStore4._0.Models.OrderModel>();
            var data = repo.getcustomerbyName(name);
            if (data != null)
            {
                foreach (var v in data)
                {
                    var order_customer = repo.getorderHistoryById(v.customer_Id);
                    foreach (var o in order_customer)
                    {
                        order.Add(CustomerMapper.orderMap(o));
                      
                    }
                    data1.Add(CustomerMapper.Map(v));
                }
                foreach(var b in order)
                {
                    var book1 = repo.GetBookById(Convert.ToInt32(b.book_Id));
                    books.Add(CustomerMapper.bookMap(book1));
                }
     
                ViewBag.Books = books;
                ViewBag.Order = order;
               
                return View(data1);
            }
            else
            {
                return Redirect("CustomerOrderHistory");
            }
            
        }
        [Authorize]
        public ActionResult getcustomerOrderbyId(int id)
        {
            var category = new List<string>();
            var books = new List<BookStore4._0.Models.BokkDetailsModel>();
            var order = new List<BookStore4._0.Models.OrderModel>();
            var data = repo.getorderHistoryById(id);
            if (data != null)
            {
                foreach (var v in data)
                {
                    order.Add(CustomerMapper.orderMap(v));
                }
                foreach (var b in order)
                {
                    var book1 = repo.GetBookById(Convert.ToInt32(b.book_Id));
                    books.Add(CustomerMapper.bookMap(book1));
                    category.Add(repo.GetCategoryDetail(book1.book_Category_id));
                }
                ViewBag.Category = category;
                ViewBag.Books = books;
                return View(order);
            }
            else
            {
                return Redirect("CustomerOrderHistory");
            }

        }
        [Authorize]
        public ActionResult Addbooks()
        {
            ViewBag.Category = new SelectList(repo.GetCategories(), "category_id", "book_category");
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Addbooks(BokkDetailsModel book)
        {
            if (ModelState.IsValid)
            {
                repo.AddBook(CustomerMapper.booksMap1(book));
                return RedirectToAction("Index");
            }
            return Redirect("getBookDetails1");

        }

    }
}