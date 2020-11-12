using CrudJeudi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CrudJeudi.Controllers
{
    public class CustomerController : Controller
    {
        // l'objet db est le context 
        ShopEntities db = new ShopEntities();

        // GET: Customer
        public ActionResult CustomerList()
        {
            var customers = db.customer.ToList();
            return View(customers);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer customer = db.customer.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult Customer()
        {

            return View();
        }
    }
}