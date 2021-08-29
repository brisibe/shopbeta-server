using Microsoft.EntityFrameworkCore;
using shopbeta.Core.Interfaces;
using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta_server.Infrastructure.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
       

        public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
           
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges) =>
            await Findall(trackChanges).OrderBy(c => c.OrderDate)
            .ToListAsync();



        public async Task<Order> GetOrdersById(Guid userId, bool trackChanges) =>
            await FindByCondition(order => order.User.Id.Equals(userId), trackChanges)
            .FirstOrDefaultAsync();

        public void CreateOrder(Order order) => Create(order);

        public void CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

    }
}
