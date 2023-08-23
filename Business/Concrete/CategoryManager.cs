﻿using Business.Abstract;
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

        public List<Category> getAll()
        {
            return _categorydal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x => x.CategoryId == id);
        }
    }
}
