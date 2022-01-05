using Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure
{
    public interface IProductServices
    {
        public Products GetById(int id); 
    }
}
