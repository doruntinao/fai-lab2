using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabCourse2.Controllers
{
      
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet]


        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validate(Login login)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbLAB2Entities"].ConnectionString;
                using (var connection = new SqlConnection(cs))
                {
                    string commandText = "SELECT username From [Login] WHERE username=@username AND password=@password";
                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@username", login.username);
                        command.Parameters.AddWithValue("@password", login.password);
                        connection.Open();

                        string userName = (string)command.ExecuteScalar();

                        if (!String.IsNullOrEmpty(userName))
                        {
                            System.Web.Security.FormsAuthentication.SetAuthCookie(login.username, true);
                            //return RedirectToAction("Index", "Home");
                            return Content("<script language='javascript' type='text/javascript'>alert('LOGIN   !');</script>");
                        }
                        TempData["Message"] = "Login failed.Username or password supplied doesn't exist.";
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                TempData["Message"] = "Login failed.Error - " + ex.Message;
            }
            return RedirectToAction("Index");

        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
