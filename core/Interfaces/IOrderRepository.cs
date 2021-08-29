using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta.Core.Interfaces
{
   public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges);
        Task<Order> GetOrdersById(Guid userId, bool trackChanges);

        void CreateOrder(Order order);

        void CancelOrder(Order order);
    }
}
