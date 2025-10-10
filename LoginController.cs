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
         [HttpPost]
      public ActionResult Update(LoginData d)//Passing parameter for function call (update function)
     {
     LoginData d2 = new LoginData();//Creating object for model class
     ViewBag.d3 = d2.update(d);
     return View("Index",d);//Passing the Index view page with 'd'

     }
      [HttpPost]
     public ActionResult Delete(LoginData d)//Passing parameter for function call (update function)
 {
     LoginData d1 = new LoginData();//Creating object for model class
     ViewBag.d4 = d1.delete(d);
     return View("Index", d);

 }
    }
}

