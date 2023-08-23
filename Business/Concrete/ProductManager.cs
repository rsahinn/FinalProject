using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Bir iş sınıfı başka sınıfları new lemez. Onun yerine constructor oluşturur. 
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new Result(true,"Ürün eklendi.");
        }

        public List<Product> getAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(x => x.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(x => x.ProductId == productId);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            return _productDal.GetProductDetail();
        }

        public List<Product> GeyByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(x => x.UnitPrice <= max && x.UnitPrice >= min);
        }
    }
}
