﻿using App.Business.Abstract;
using App.Entities.Concrete;
using App.DataAccess.Abstract;
using System.Collections.Generic;
using App.DataAccess.Concrete.EfEntityFramework;


namespace App.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public CategoryService()
        {
            _categoryDal = new EfCategoryDal();
        }
        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
