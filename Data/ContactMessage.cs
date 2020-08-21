using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Messsage { get; set; }
    }
}
