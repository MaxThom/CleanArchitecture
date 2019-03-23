using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
