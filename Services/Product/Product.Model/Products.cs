using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Model
{
    public class Products
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Expiration_Date { get; set; }
    }
}
