using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.ApplicationService
{
    public class ContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void AddContact(string phonNumber ,int CustomerId )
        {
            if (!string.IsNullOrEmpty( phonNumber) && CustomerId != null)
            {
                var contactIndb = _contactRepository.FindByPhoneNumber(phonNumber); 
                if (contactIndb == null || contactIndb.ContactID < 1 )
                {
                    var contact = new Contact
                    {
                        PhoneNumber = phonNumber , 
                        CustomerID = CustomerId


                    };
                    _contactRepository.Add(contact);
                }
            }
        }
        public void RemoveContact(int id)
        {
            var contact = _contactRepository.FindById(id) ;
            if(contact != null || contact.ContactID >= 1)
                _contactRepository.Remove(contact);
        }

        public List<Contact>  GetAllContact ()
        {
            var contacts = _contactRepository.GetAll();
            return contacts; 
        }
        public Contact FindByIdContact(int id)
        {
            var contact = _contactRepository.FindById(id);
            return contact; 
        }
        public Contact FindByPhonNumberContact (string phonNumber )
        {
            var contact = _contactRepository.FindByPhoneNumber(phonNumber);
            return contact;
        }
    }
}
