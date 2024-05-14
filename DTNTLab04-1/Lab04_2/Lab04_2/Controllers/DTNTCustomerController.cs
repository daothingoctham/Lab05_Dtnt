using Lab04_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04_2.Controllers
{
    public class DTNTCustomerController : Controller
    {
        // GET: DTNTCustomer
        //khai báo biến CustomerRepository
        static DTNTCustomerController listCustomer;
        public DTNTCustomerController()
        {
            listCustomer = new DTNTCustomerController();
        }
            // GET: /Customer/GetCustomers
            public ActionResult GetDtntCustomer()
            {
                return View(listCustomer.GetDtntCustomer());
            }
            //POST: /Customer/GetCustomers
            [HttpPost]
            public ActionResult GetDtntCustomer(string name)
            {
                return View(listCustomer.SearchDtntCustomer(name));
            }

        private object SearchDtntCustomer(string name)
        {
            throw new NotImplementedException();
        }

        // GET: /Customer/Details/5
        public ActionResult Details(string id)
            {
                return View(listCustomer.GetDtntCustomer(id));
            }
            // GET: /Customer/Create
            public ActionResult Create()
            {
                return View();
            }
            // POST: /Customer/Create
            [HttpPost]
            public ActionResult Create(DtntCustomer cus)
            {
                listCustomer.AddDtntCustomer(cus);
                return RedirectToAction("GetDtntCustomer");
            }

        private void AddDtntCustomer(DtntCustomer cus)
        {
            throw new NotImplementedException();
        }

        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
            {
                return View(listCustomer.GetDtntCustomer(id));
            }
            // POST: /Customer/Edit
            [HttpPost]
            public ActionResult Edit(DtntCustomer cus)
            {
                listCustomer.UpdateDtntCustomer(cus);
                return RedirectToAction("GetDtntCustomer");
            }

        private void UpdateDtntCustomer(DtntCustomer cus)
        {
            throw new NotImplementedException();
        }

        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
            {
                listCustomer.DeleteDtntCustomer(listCustomer.GetDtntCustomer(id));
                return RedirectToAction("GetDtntCustomer");
            }

        private void DeleteDtntCustomer(ActionResult actionResult)
        {
            throw new NotImplementedException();
        }
    }
    }