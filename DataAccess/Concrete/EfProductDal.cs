using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

using System.Collections.Generic;
using System.Linq;
namespace DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MyTaskProjectDbContext>, IProductDal
    {
       
    }
}
