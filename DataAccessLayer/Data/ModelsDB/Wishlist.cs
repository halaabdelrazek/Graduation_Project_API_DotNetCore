using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Guid Id { get; set; }
        public DateTime DateAdded { get; set; }

        [ForeignKey("User")]

        public String UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<WishlistProduct> WishlistProduct { get; set; }

    }
}
