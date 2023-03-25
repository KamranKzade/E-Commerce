using App.Entities.Concrete;
using System.Collections.Generic;



namespace App.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetById(int categoryId);
    }
}
