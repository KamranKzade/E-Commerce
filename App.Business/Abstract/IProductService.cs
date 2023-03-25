using App.Entities.Concrete;
using System.Collections.Generic;


namespace App.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);   
        void Delete(Product product);
        Product GetById(int productId);
    }
}
