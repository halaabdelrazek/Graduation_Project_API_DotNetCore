using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class WishlistProduct
    {
        public Guid WishlistId { get; set; }
        public Guid ProductId { get; set; }
        public Wishlist Wishlist { get; set; }  
        public Product Product { get; set; }
    }
}
