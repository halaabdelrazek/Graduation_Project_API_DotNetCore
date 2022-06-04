using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Wishlist
    {
    
        public Wishlist()
        {
            WishlistProduct = new HashSet<WishlistProduct>();
        }
        public Guid ID { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<WishlistProduct> WishlistProduct { get; set; }

    }
}
