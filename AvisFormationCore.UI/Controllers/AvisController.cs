using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.UI.Controllers
{
    public class AvisController : Controller
    {
        public IActionResult LaisserUnAvis(string idFormation)
        {
            int id = -1;
            int.TryParse(idFormation,out id);
            FormationMemoryRepository repository = new FormationMemoryRepository();
            Formation formation = repository.getFormationById(id);
            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations","Formation");
            }
            return View(formation);
        }
        [HttpPost]
        public IActionResult SaveComment(string nom, string commentaire,string note)
        {
            return View();
        }
    }
}
