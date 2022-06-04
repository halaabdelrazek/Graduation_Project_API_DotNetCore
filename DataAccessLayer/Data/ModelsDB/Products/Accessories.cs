using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Accessories:Product
    {
        public Accessories()
        {
            Reviews = new HashSet<Review>();
        }
        public Guid SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }
}
