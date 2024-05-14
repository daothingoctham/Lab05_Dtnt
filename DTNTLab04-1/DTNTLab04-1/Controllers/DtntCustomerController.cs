using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTNTLab04_1.Models;

namespace DTNTLab04_1.Controllers
{
    public class DtntCustomerController : Controller
    {
        // GET: DtntCustomer
        public ActionResult DTNTCustomerDetail()
        {
            DtntCustomer cus = new DtntCustomer()
            {
                CustomerId = "CNTT2",
                FullName = "Đào Ngọc Thắm",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "037.4270.572",
                Balance = 22000
            };
            return View(cus);
        }
        public ActionResult DTNTCustomerList()
        {
            List<DtntCustomer> listcustomer = new List<DtntCustomer>()
            {
                new DtntCustomer()
                { 
                    CustomerId = "CNTT2",
                    FullName = "Đào Ngọc Thắm",
                    Address = "Hà Nội",
                    Email = "devmaster.founder@gmail.com",
                    Phone = "0978.611.889",
                    Balance = 220000 
                },
                new DtntCustomer()
                { 
                    CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",
                    Address = "Hà Nội",
                    Email = "cucdt@gmail.com",
                    Phone = "0986.767.444",
                    Balance = 2200000
                },
                new DtntCustomer()
                { 
                    CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",
                    Address = "Nam Định",
                    Email = "thangnt@gmail.com",
                    Phone = "0924.656.542",
                    Balance = 1200000
                },
                new DtntCustomer()
                { 
                    CustomerId = "KH004", 
                    FullName = "Lê Ngọc Hải",
                    Address = "Hà Nội",
                    Email = "hailn@gmail.com",
                    Phone = "0996.555.267",
                    Balance = 6200000 
                }
             };
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}
