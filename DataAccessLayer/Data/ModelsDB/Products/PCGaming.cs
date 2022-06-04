using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class PCGaming:Product
    {
        public PCGaming()
        {
            Reviews = new HashSet<Review>();
        }
        public string MemorySpeed { get; set; }
        public string CPUSpeed { get; set; }
        public string OS { get; set; }
        public string GraphicsCard { get; set; }

        public Guid SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }
}
