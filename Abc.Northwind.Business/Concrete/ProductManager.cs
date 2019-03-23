using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.DataAccess.Concrete.EntityFramework;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager
    {
        private IProductDal productDal;

        public List<Product> GetProducts()
        {
            
            return productDal.GetList();
        }

    }
}
