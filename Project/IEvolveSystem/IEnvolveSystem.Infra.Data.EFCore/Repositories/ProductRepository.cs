using IEnvolveSystem.Infra.Data.EFCore.Contexts;
using IEvolveSystem.Domain.Entities;
using IEvolveSystem.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnvolveSystem.Infra.Data.EFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppEFCoreDbContext _context;

        public ProductRepository(AppEFCoreDbContext context)
        {
            _context = context;
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Remove(product ?? new Product());
            _context.SaveChanges();
        }

        public Product GetById(int id)
        {
            var result = _context.Products.Find(id);
            return result ?? new Product();
        }

        public Product Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}
