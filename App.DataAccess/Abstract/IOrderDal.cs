using App.Core.DataAccess;
using App.Entities.Concrete;

namespace App.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        // custom operation
    }
}
