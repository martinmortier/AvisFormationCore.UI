using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.UI.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.UI.Controllers
{
    public class AvisController : Controller
    {
        IFormationRepository _repository;
        IAvisRepository _avisRepository;
        public AvisController(IFormationRepository repository, IAvisRepository avisRepository)
        {
            _repository = repository;
            _avisRepository = avisRepository;
        }
        public IActionResult LaisserUnAvis(string idFormation)
        {
            int id = -1;
            int.TryParse(idFormation,out id);
            Formation formation = _repository.getFormationById(id);
            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations","Formation");
            }
            var vm = new LaisserUnAvisViewModel();
            vm.NomFormation = formation.Nom;
            vm.idFormation = formation.Id.ToString();
            return View(vm);
        }
        [HttpPost]
        public IActionResult SaveComment(LaisserUnAvisViewModel laisserUnAvisViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("LaisserUnAvis", laisserUnAvisViewModel);
            }

            if(string.IsNullOrEmpty(laisserUnAvisViewModel.nom) || string.IsNullOrEmpty(laisserUnAvisViewModel.note))
            {
                return RedirectToAction("LaisserUnAvis");
            }
            _avisRepository.SaveAvis(laisserUnAvisViewModel.commentaire, laisserUnAvisViewModel.nom, laisserUnAvisViewModel.idFormation,laisserUnAvisViewModel.note) ;
            return RedirectToAction("DetailsFormation","Formation",new { idFormation = laisserUnAvisViewModel.idFormation });
        }
    }
}
