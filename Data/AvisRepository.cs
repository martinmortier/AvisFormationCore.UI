using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class AvisRepository : IAvisRepository
    {
        public MonDbContext _context;
        public AvisRepository(MonDbContext context)
        {
            _context = context;
        }
        public void SaveAvis(string commentaire, string nom, string idFormation,string note)
        {
            int iIdFormation = -1;
            double dNote = -1;
            if(!int.TryParse(idFormation,out iIdFormation))
            {
                return;
            }
            if(!double.TryParse(note,out dNote))
            {
                return;
            }
            var Avis = new Avis();
            Avis.Commentaire = commentaire;
            Avis.NomUtilisateur = nom;
            Avis.FormationId = iIdFormation;
            Avis.Note = dNote;

            _context.Avis.Add(Avis);
            _context.SaveChanges();
        }
    }
}
