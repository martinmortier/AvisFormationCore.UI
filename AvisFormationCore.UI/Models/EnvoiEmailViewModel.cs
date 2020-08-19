using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.UI.Models
{
    public class EnvoiEmailViewModel
    {
        public string Nom { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(20)]
        public string Message { get; set; }
    }
}
