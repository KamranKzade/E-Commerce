using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.Entities.Concrete;

namespace App.DataAccess.Concrete.EfEntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
