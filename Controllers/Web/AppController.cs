﻿using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorld.Services;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailServices _mailService;

        public AppController(IMailServices service)
        {
            _mailService = service;
        }
        public IActionResult Index() {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];
                if (String.IsNullOrWhiteSpace(email)) {
                    ModelState.AddModelError("", "Could not send email, configuration form");
                }
                if (_mailService.SendMail(
                    email,
                    email,
                    $"Contact Page prom {model.Name}({model.Email})",
                    model.Message))
                {
                    ModelState.Clear();
                    ViewBag.Message = "Mail Sent. Thanks";
                }
            }

            return View();
        }
    }
}