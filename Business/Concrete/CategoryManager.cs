using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public IDataResult<List<Category>> getAll()
        {
            return new SuccessDataResult<List<Category>>(_categorydal.GetAll());
                
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categorydal.Get(x => x.CategoryId == id));
                
        }
    }
}
