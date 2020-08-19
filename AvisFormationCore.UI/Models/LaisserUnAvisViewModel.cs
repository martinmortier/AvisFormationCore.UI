using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.UI.Models
{
    public class LaisserUnAvisViewModel
    {
        [StringLength(5,ErrorMessage ="Le texte dépasse la taille maximal de 5")]
        public string nom { get; set; }
        [Required]
        public string commentaire { get; set; }
        [Required]
        public string note { get; set; }
        [Required]
        public string idFormation { get; set; }
        public string NomFormation { get; set; }

    }
}
