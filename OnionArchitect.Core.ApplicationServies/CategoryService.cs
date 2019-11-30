using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.ApplicationServies
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void AddCategory(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                var categoryInDb = _categoryRepository.FindByName(name);
                if (categoryInDb == null || categoryInDb.CategoryID<1)
                {
                    var category = new Category
                    {
                        Name = name
                    };

                    _categoryRepository.Add(category);

                }
            }
        }
        public void RemoveCategory(int id )
        {
            var catrgory = _categoryRepository.FindByID(id);
            if(catrgory != null || catrgory.CategoryID >= 1)
            {
                _categoryRepository.Remove(catrgory); 
            }
        }

        public List<Category>  GetAllCategory ()
        {
            var categories = _categoryRepository.GetAll();
            return categories; 
        }
        public Category FindByNameCategory (string name)
        {
            var category = _categoryRepository.FindByName(name);
            return category; 
        }
        public Category FindByIdCategory(int id )
        {
            var category = _categoryRepository.FindByID(id);
            return category;
        }
    }
}
