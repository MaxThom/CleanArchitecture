﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
