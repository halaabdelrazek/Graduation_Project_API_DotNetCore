using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ProductImage
    {
        public Guid  Id { get; set; }   

        public string? ImageURL { get; set; }

        public Guid ProductId { get; set; }
        
        public Product Product { get; set; }
    }
}
