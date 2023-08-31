using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorydal = categoryDal;
        }
        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categorydal.GetList().ToList());
        }
    }
}
