using Product.Infrastructure;
using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Services
{
    public class ProductServices : IProductServices
    {
        public Products GetById(int id)
        {
            return new Products()
            {
                Product_Id = new Random().Next(100),
                Name = "Iphone X",
                Stock = 3,
                Price = 10499.00,
                IsActive = false,
                Expiration_Date = DateTime.Now.AddYears(10)
            };
        }
    }
}
