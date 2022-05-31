using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public Guid Id { get; set; }

        public string? CategoryName{ get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
