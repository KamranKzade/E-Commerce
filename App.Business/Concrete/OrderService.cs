using App.Business.Abstract;
using App.Entities.Concrete;
using App.DataAccess.Abstract;
using System.Collections.Generic;
using App.DataAccess.Concrete.EfEntityFramework;

namespace App.Business.Concrete
{
    public class OrderService : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderService()
        {
            _orderDal = new EfOrderDal();
        }

        public OrderService(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order product)
        {
            _orderDal.Add(product);
        }

        public void Delete(Order product)
        {
            _orderDal.Delete(product);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetList();
        }

        public Order GetById(int orderId)
        {
            return _orderDal.Get(o => o.OrderId == orderId);
        }

        public void Update(Order product)
        {
            _orderDal.Update(product);
        }
    }
}
