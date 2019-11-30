using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.DAL.EF
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private static List<Category> categories =new List<Category>(); 

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public Category FindByID(int id)
        {
            return categories.Find(c => c.CategoryID == id);
        }

        public Category FindByName(string name)
        {
            return categories.FirstOrDefault(c => c.Name == name);
        }

        public List<Category> GetAll()
        {
            return categories.ToList(); 
        }

        public void Remove(Category category)
        {
            categories.Remove(category);
        }
    }
}
