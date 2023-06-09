﻿using App.Core.DataAccess;
using App.Entities.Concrete;

namespace App.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        //custom operations
    }
}
