using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.UI.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.UI.Controllers
{
    public class ContactController : Controller
    {
        IContactRepository contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }
        public IActionResult Index()
        {
            var vm = new EnvoiEmailViewModel();
            return View(vm);
        }
        [HttpPost]
        public IActionResult SaveMessage(EnvoiEmailViewModel envoiEmailViewModel)
        {
            contactRepository.SaveMessage(envoiEmailViewModel.Nom, envoiEmailViewModel.Email, envoiEmailViewModel.Message);
            return View();
        }
    }
}
