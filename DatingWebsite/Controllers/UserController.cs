using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DatingWebsite.Models;

namespace DatingWebsite.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var ctx = new UserDbContext();
            var viewModel = new UserIndexViewModel
            {
                Users = ctx.Users.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddUser(User model)
        {
            var ctx = new UserDbContext();
            ctx.Users.Add(model);
            ctx.SaveChanges();

            return Redirect("/User/Index");
        }
    }
}