﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetAllCategoryId(int id);
        IDataResult<Category> GetById(int categoryId);
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);

    }
}
