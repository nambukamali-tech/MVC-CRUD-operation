using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Practice10.Models;


namespace Practice10.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Insert()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult Insert(DataStorage d)
        {

            using (SqlConnection con = new SqlConnection("Data Source =DESKTOP-EHPCDIL\\SQLEXPRESS; Initial Catalog=Practice10 ; Integrated Security=True")) //SQLConnection
            {
                string sqlQuery = "Insert into details(name,area, salary)values(@name , @area , @salary)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))//SQLCommand
                {
                    cmd.Parameters.AddWithValue("@name", d.name);
                    cmd.Parameters.AddWithValue("@area", d.area);
                    cmd.Parameters.AddWithValue("@salary", d.salary);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                
            }
            ViewBag.message = "Insertion Successfully";
            return View("Index");

        }

    }
}
