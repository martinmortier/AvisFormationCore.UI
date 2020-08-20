using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Formation
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string NomSEO { get; set; }

        public string Description { get; set; }

        public List<Avis> Avis { get; set; }
    }
}
