﻿using App.Core.DataAccess;
using App.Entities.Concrete;


namespace App.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //custom operations
    }
}
