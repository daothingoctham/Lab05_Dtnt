using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04.Models;
namespace Lab04.Controllers
{
    public class DTNTcustomerController : Controller
    {
        // GET: DTNTcustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DTNTCustomerDetail()
        {
            DTNTcustomer customer = new DTNTcustomer()
            {
                CustomerID = 1,
                FirstName = "ĐÀO NGỌC",
                LastName ="THẮM",
                Address ="K22CNT2",
                YearofBirth = 2004
            };

            ViewBag.Customer = customer;
            return View(customer);
        }
        public ActionResult DTNTListCustomer()
        {
            List<DTNTcustomer> listcustomer = new List<DTNTcustomer>()
            {
                new DTNTcustomer()
                {
                CustomerID = 1,
                FirstName = "ĐÀO NGỌC",
                LastName ="THẮM",
                Address ="K22CNT2",
                YearofBirth = 2004
                },
                new DTNTcustomer()
                {
                    CustomerID = 2,
                    LastName ="Hồng",
                    FirstName = "Tạ Thị",
                    Address ="K22CNT2",
                    YearofBirth = 2004
                },
                new DTNTcustomer()
                {
                    CustomerID = 3,
                    LastName ="Hồng 2",
                    FirstName = "Tạ Thị",
                    Address ="K22CNT2",
                    YearofBirth = 2004
                },
            };
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}