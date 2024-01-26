using Login_page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_page.Controllers
{
    public class HomeController : Controller
    {
       login1Entities db = new login1Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user log)
        {
            var user= db.users.Where(x => x.Username == log.Username && x.password == log.password).Count();
            if (user>0)
            {
                return RedirectToAction("Dashboard");

            }
            else
            {
                return View();

            }

            
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}