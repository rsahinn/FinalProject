using Core.Utilities.Results;
using Entitiy.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> getAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GeyByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetail();
        Product GetById(int productId);

        IResult Add(Product product);
    }
}
