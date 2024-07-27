using IEvolveSystem.Domain.Entities;
using IEvolveSystem.Domain.Interfaces.Repositories;
using IEvolveSystem.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product.ProductId);
        }

        public Product Update(Product product)
        {
            return (_productRepository.Update(product));
        }
    }
}
