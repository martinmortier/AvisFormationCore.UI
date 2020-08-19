using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var vm = new EnvoiEmailViewModel();
            return View(vm);
        }
        [HttpPost]
        public IActionResult SaveMessage(EnvoiEmailViewModel envoiEmailViewModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", envoiEmailViewModel);
            }
            return View();
        }
    }
}
