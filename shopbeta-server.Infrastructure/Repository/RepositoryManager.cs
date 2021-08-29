using shopbeta.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta_server.Infrastructure.Repository
{
  public  class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null) _productRepository = new ProductRepository(_repositoryContext);
                return _productRepository;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (_orderRepository == null) _orderRepository = new OrderRepository(_repositoryContext);
                return _orderRepository;
            }
        }

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
      
    }
}
