using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entitiy.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { new Product{ ProductId=1,CategoryId=1,ProductName="Masa",UnitsInStock=20,UnitPrice=1000},
            new Product{ProductId=2,CategoryId=1,ProductName="Bardak",UnitsInStock=133,UnitPrice=50},
            new Product{ProductId=3,CategoryId=2,ProductName="Sürahi",UnitsInStock=40,UnitPrice=100},
            new Product{ProductId=4,CategoryId=3,ProductName="Bıçak",UnitsInStock=342,UnitPrice=80},
            new Product{ProductId=5,CategoryId=3,ProductName="Çatal",UnitsInStock=87,UnitPrice=70}};
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            Product productToDelete;
               productToDelete = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
               _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            Product productToUpdate;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.ProductId = entity.ProductId;
            productToUpdate.UnitPrice = entity.UnitPrice;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
            productToUpdate.CategoryId = entity.CategoryId;
        }

        
    }
}
