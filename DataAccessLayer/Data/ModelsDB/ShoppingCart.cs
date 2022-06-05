using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
     

            ProductCarts = new HashSet<ProductCart>();
        }
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public String UserId { get; set; }
        public virtual User User { get; set; }
       

        public virtual ICollection<ProductCart> ProductCarts { get; set; }

    }
}
