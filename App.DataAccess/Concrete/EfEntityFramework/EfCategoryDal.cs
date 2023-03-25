using App.Entities.Concrete;
using App.DataAccess.Abstract;
using App.Core.DataAccess.EntityFramework;

namespace App.DataAccess.Concrete.EfEntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
