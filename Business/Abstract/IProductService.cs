using Entitiy.Concrete;
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
    }
}
