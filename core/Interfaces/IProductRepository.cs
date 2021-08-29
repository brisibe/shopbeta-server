using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta.Core.Interfaces
{
   public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);

        Task<Product> GetProductAsync(Guid productId, bool trackChanges); 

        void CreateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
