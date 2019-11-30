using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Contracts
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        void Add(Contact contact);
        void Remove(Contact contact);
        Contact FindById(int id);
        Contact FindByPhoneNumber(string phonNumber);
    }
}
