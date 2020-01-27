﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Activity2Part3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(Activity2Part3.Models.UserModel model)
        {
            if (!ModelState.IsValid)
                return View("Login");
            Services.Business.SecurityService service = new Services.Business.SecurityService();

            bool authenticated = service.Authenticate(model);

            if (authenticated)
            {
                return View("LoginPassed", model);
            } else
            {
                return View("LoginFailed");
            }
        }
    }
}