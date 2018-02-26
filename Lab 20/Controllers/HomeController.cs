using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_20.Models;

namespace Lab_20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult UserInformation(string FirstName, string LastName,string Password, string Address, string City, string State, string Zip, string Email, string gender)
        {
            ViewBag.Name = $"{FirstName} {LastName}";
            ViewBag.Address = Address;
            ViewBag.City = City;
            ViewBag.State = State;
            ViewBag.Zip = Zip;
            ViewBag.Email = Email;
            ViewBag.Gender = gender;
            string UserPassword = Password;

            return View("DisplayUserInformation");
        }
        public ActionResult BrowseProducts()
        {
            CoffeeShopEntities Items = new CoffeeShopEntities();
            ViewBag.ItemData = Items.Items.ToList();
            return View("BrowseProducts");
        }
 
    }
}