using MVCcrudoperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCcrudoperation.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginData d)//Passing parameter for function call
        {
            LoginData d1 = new LoginData();//Creating object for model class
            ViewBag.d2 = d1.save(d);
            return View();

        }

    }
}