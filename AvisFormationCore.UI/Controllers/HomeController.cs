using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AvisFormationCore.UI.Models;
using Data;

namespace AvisFormationCore.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            FormationMemoryRepository repository = new FormationMemoryRepository();
            List<Formation> listFormations = repository.GetFormations(4);

            var list = Enumerable.Range(0, 500).ToList();
            var listePaire = list.Where(nb => nb % 2 == 0);
            var listeValeur = list.FirstOrDefault(nb => nb == 250);
            var listeDivisepar2 = list.Select(nb => nb / 2);
            foreach(var i in listePaire)
            {
                Debug.WriteLine(i);
            }
            return View(listFormations);
        }
    }
}
