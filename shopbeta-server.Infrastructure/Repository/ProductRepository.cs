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
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges) =>
            await Findall(trackChanges).OrderBy(c => c.Name)
            .ToListAsync();


        public async Task<Product> GetProductAsync(Guid productId, bool trackChanges) =>
            await FindByCondition(product => product.ProductId.Equals(productId), trackChanges)
            .FirstOrDefaultAsync();


        public void CreateProduct(Product product) => Create(product);




        public void DeleteProduct(Product product) => Delete(product);
      

    
    }
}
