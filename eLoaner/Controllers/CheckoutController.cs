using eLoaner.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLoaner.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Checkout
        public ActionResult Index()
        {
            var viewModel = new CheckoutViewModel
            {
                CheckOuts = _context.Checkouts.Where(item => item.IsDeleted == false).ToList(),
                Customers = _context.Customers.Where(item => item.IsDeleted == false).ToList(),
                Assets = _context.Assets.Where(item => item.IsDeleted == false).ToList(),
                Checkout = new Checkout()
            };
            return View(viewModel);
        }

        public ActionResult Create()
        {
            var viewmodel = new CheckoutViewModel
            {
                Customers = _context.Customers.ToList(),
                Assets = _context.Assets.ToList(),
                Checkout = new Checkout()
            };
            return View(viewmodel);
        }
        [HttpPost]
        public ActionResult Create(CheckoutViewModel model)
        {
            var myCheckOut = model.Checkout;
            myCheckOut.IsDeleted = false;
            myCheckOut.CheckOutDate = DateTime.Now;
            myCheckOut.CheckedOutBy = User.Identity.Name;
            myCheckOut.LastModifiedBy = User.Identity.Name;
            myCheckOut.LastModifiedOn = DateTime.Now;

            var viewmodel = new CheckoutViewModel
            {
                Customers = _context.Customers.Where(c => c.IsDeleted == false).ToList(),
                Assets = _context.Assets.Where(c => c.IsDeleted == false).ToList(),
                Checkout = myCheckOut
            };

            try
            {
                _context.Checkouts.Add(myCheckOut);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
            
            }
            return View(viewmodel);
        }

        [HttpGet]
        public ActionResult CheckIn(int id)
        {
            try
            {
                var model = _context.Checkouts.FirstOrDefault(item => item.Id == id);
                if (model != null)
                {

                    model.LastModifiedOn = DateTime.Now;
                    model.LastModifiedBy = User.Identity.Name;
                    model.IsDeleted = true;
                    model.CheckInDate = DateTime.Now;
                    _context.Checkouts.Attach(model);
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Checkout/Delete/1
        public ActionResult Delete(int id)
        {
            var model = _context.Checkouts.FirstOrDefault(item => item.Id == id);

            if (model == null)
            {
                model = new Checkout();
            }

            return View(model);
        }

        // POST: Author/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete object here
                var model = _context.Checkouts.FirstOrDefault(item => item.Id == id);
                if (model != null)
                {

                    model.LastModifiedOn = DateTime.Now;
                    model.LastModifiedBy = User.Identity.Name;
                    model.IsDeleted = true;
                    _context.Checkouts.Attach(model);
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}