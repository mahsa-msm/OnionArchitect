using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.DAL.EF
{
    public class FackContactRepository : IContactRepository
    {
        private static List<Contact> contacts = new List<Contact>();
        public void Add(Contact contact)
        {
            contacts.Add(contact); 
        }

        public Contact FindById(int id)
        {
             return contacts.Find(c => c.ContactID == id); 
        }

        public Contact FindByPhoneNumber(string phonNumber)
        {
            return contacts.FirstOrDefault(c => c.PhoneNumber == phonNumber); 
        }

        public List<Contact> GetAll()
        {
            return contacts.ToList(); 
        }

        public void Remove(Contact contact)
        {
            contacts.Remove(contact); 
        }
    }
}
