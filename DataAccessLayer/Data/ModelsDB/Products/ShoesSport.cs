using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ShoesSport : Product
    {
        public ShoesSport()
        {
            Reviews = new HashSet<Review>();
        }
        public int Size { get; set; }
        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}
