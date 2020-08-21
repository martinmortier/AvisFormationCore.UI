using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ContactRepository : IContactRepository
    {
        MonDbContext _context;
        public ContactRepository(MonDbContext context)
        {
            this._context = context;
        }
        public void SaveMessage(string nom, string email, string msg)
        {
            var message = new ContactMessage();
            message.Nom = nom;
            message.Email = email;
            message.Messsage = msg;

            _context.Messages.Add(message);
            _context.SaveChanges();
        }
    }
}
