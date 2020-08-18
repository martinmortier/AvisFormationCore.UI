using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.UI.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.UI.Controllers
{
    public class FormationController : Controller
    {
        public IActionResult Index()
        {
            ToutesLesFormationsViewModel vm = new ToutesLesFormationsViewModel();
            vm.Message = "Ceci est un message du controlleur";
            vm.Nombre = 93;
            return View(vm);
        }

        public IActionResult ToutesLesFormations()
        {
            FormationMemoryRepository repository = new FormationMemoryRepository();
            List<Formation> listFormations = repository.GetAllFormations();
            return View(listFormations);
        }

        public IActionResult DetailsFormation(string idFormation)
        {
            int iIdFormation = -1;
            if(!int.TryParse(idFormation,out iIdFormation))
            {
                return RedirectToAction("ToutesLesFormations");
            }
            FormationMemoryRepository repository = new FormationMemoryRepository();
            Formation formation = repository.getFormationById(iIdFormation);
            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations");
            } 
            return View(formation);
        }
    }
}
