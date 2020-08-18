using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class FormationMemoryRepository
    {
        private List<Formation> _formations = new List<Formation>();

        public FormationMemoryRepository()
        {
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site web avec ASP.NET", Description = "asp-net-core", NomSEO = "" });
            _formations.Add(new Formation { Id = 2, Nom = "Jardinage", Description = "asp-net-core", NomSEO = "" });
            _formations.Add(new Formation { Id = 3, Nom = "Photo pro", Description = "asp-net-core", NomSEO = "" });
        }
        public List<Formation> GetAllFormations()
        {
            return _formations;
        }

        public Formation getFormationById(int idFormation)
        {
            //foreach(var f in _formations)
            //{
            //    if(f.Id == idFormation)
            //    {
            //        return f;
            //    }
            //}

            return _formations.Where(f => f.Id == idFormation).FirstOrDefault();
        }
    }
}
