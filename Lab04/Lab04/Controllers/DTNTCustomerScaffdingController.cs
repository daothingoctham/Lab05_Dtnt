using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Controllers
{
    public class DTNTCustomerScaffdingController : Controller
    {
        private static List<DTNTcustomer> listcustomer = new List<DTNTcustomer>()
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

        // GET: DTNTCustomerScaffding
        public ActionResult Index()
        {
            return View(listcustomer);
        }
        [HttpGet]
        public ActionResult DTNTcreate()
        {
            var modle = new DTNTcustomer();
            return View(modle);
        }
        [HttpGet]
        public ActionResult DTNTcreate(DTNTcustomer model )
        {
            listcustomer.Add(model);

            return RedirectToAction("Index");
        }
        public ActionResult DTNTEdit(int ID)
        {
            var customer = listcustomer.FirstOrDefault(x=>x.CustomerID==ID);
            return View(customer);
        }
    }
}