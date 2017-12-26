using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Emty_Kolekcioner_FIKT.Models;

namespace Emty_Kolekcioner_FIKT.Controllers
{
    public class KolekcionerController : Controller
    {
        // GET: Kolekcioner
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewPhoto()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public ActionResult NewPhoto(AddKolekcion kolekcija)
        {
            if(ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.AddKolekcion.Add(kolekcija);
                    db.SaveChanges();
                }
                ModelState.Clear();
            }
            return View();
        }


    }
}
