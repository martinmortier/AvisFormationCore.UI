using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class FormationRepository : IFormationRepository
    {
        MonDbContext _context;

        public FormationRepository(MonDbContext context)
        {
            _context = context;
        }


        public List<Formation> GetAllFormations()
        {
            return _context.Formations.ToList();
        }

        public List<Formation> GetFormations(int nombre)
        {
            return _context.Formations.OrderBy(qu => Guid.NewGuid()).Take(nombre).ToList();
        }

        public Formation getFormationById(int idFormation)
        {
           return _context.Formations.Where(f => f.Id == idFormation).FirstOrDefault();
        }
    }
}
