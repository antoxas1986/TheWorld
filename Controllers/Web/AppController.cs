using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorld.Model;
using TheWorld.Services;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailServices _mailService;
        private IWorldRepository _repository;

        public AppController(IMailServices service, IWorldRepository repository)
        {
            _mailService = service;
            _repository = repository;
        }
        public IActionResult Index() {
            var Trips = _repository.GetAllTrips();
            return View(Trips);
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
                    $"Contact Page from {model.Name}({model.Email})",
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
