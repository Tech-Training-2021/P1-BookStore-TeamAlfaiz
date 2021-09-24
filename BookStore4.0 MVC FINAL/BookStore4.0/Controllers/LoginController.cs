using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Data.Entities;
using BookStore4._0.Models;
using System.Web.Security;
namespace BookStore4._0.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        customerRepo repo;
        public LoginController()
        {
            repo = new customerRepo(new Model1());
        }
       
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            var login = repo.LoginCustomer(Email, Password);
            if (login != null) {

                HttpCookie cookie = new HttpCookie("User_id",(login.customer_Id).ToString());
                Response.Cookies.Add(cookie);
                HttpCookie cookie1= new HttpCookie("User_email", (login.customer_Email).ToString());
                Response.Cookies.Add(cookie1);
                FormsAuthentication.SetAuthCookie(Email, false);
                if (Request.Cookies["User_email"].Value.ToString() == "israk@gmail.com") {
                    return RedirectToAction("getBookDetails1", "Book");
                }
                else
                {
                    return RedirectToAction("getBookDetails", "Book");
                }
           
            }

            ModelState.AddModelError("", "Invalid username or password");
            return View();
        }
        public ActionResult Logout()
        {
            var c = new HttpCookie("User_id")
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Add(c);
            var c1 = new HttpCookie("User_email")
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Add(c1);
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}