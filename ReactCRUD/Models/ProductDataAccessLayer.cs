using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCRUD.Models
{
    public class ProductDataAccessLayer
    {
        PowerAppDBContext dbContext = new PowerAppDBContext();

        public List<Product> GetAllProducts()
        {
            try
            {
                return dbContext.Product.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AddProduct(Product product)
        {
            try
            {
                dbContext.Product.Add(product);
                dbContext.SaveChanges();
                return +1;
            }
            catch
            {
                throw;
            }
        }
    }
}
