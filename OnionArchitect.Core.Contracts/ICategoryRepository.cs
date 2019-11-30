using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Contracts
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        Category FindByID(int id);
        Category FindByName(string name);

    }
}
