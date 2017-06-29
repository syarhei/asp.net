using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APP.Models;
using System.Data.Entity;

namespace MVC_APP.Controllers {
    public class PhoneController : Controller {

        PhoneContext Phones = new PhoneContext();

        // GET: Phone
        public ActionResult Index() {
            return View("Index", Phones.Phones);
        }

        public ActionResult Add() {
            Phone fm = new Models.Phone();
            return View("Add", fm);
        }

        [HttpPost]
        public ActionResult Add(Phone phone) {
            if (phone.BDay < DateTime.Now.AddYears(-120)) {
                ModelState.AddModelError("BDay", "Error in birth date");
            }

            if (ModelState.IsValid) {
                Phones.Phones.Add(phone);
                Phones.SaveChanges();
                return View("Index", Phones.Phones);
            } else {
                return View();
            }
        }

        public ActionResult Update(int id) {
            Phone phone = Phones.Phones.Find(id);
            return (View("Update", phone));
        }

        [HttpPost]
        public ActionResult Update(Phone phone) {
            if (ModelState.IsValid) {
                Phones.Entry(phone).State = EntityState.Modified;
                Phones.SaveChanges();
                return (View("Index", Phones.Phones));
            } else {
                ViewBag.ErrorTxt = "Update: error";
                return View("Index", Phones.Phones);
            }
        }

        public ActionResult Delete(int id) {
            Phone phone = Phones.Phones.Find(id);
            return View("Delete", phone);
        }

        [HttpPost]
        public ActionResult Delete(Phone phone) {
            phone = Phones.Phones.Find(phone.ID);
            if (phone != null && ModelState.IsValid) {
                Phones.Phones.Remove(phone);
                Phones.SaveChanges();
                return View("Index", Phones.Phones);
            } else {
                ViewBag.ErrorTxt = "Delete: error";
                return View("Index", Phones.Phones);
            }
        }
    }
}