using App.Entities.Concrete;
using System.Collections.Generic;

namespace App.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        void Add(Order product);
        void Update(Order product);
        void Delete(Order product);
        Order GetById(int orderId);
    }
}
