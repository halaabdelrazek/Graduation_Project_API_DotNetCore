using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public enum Type
    {
        Female = 1,
        Male
    }
    public class Perfume:Product
    {
        public Perfume()
        {
            Reviews = new HashSet<Review>();
        }
        public string Volume { get; set; }
        public string Scent { get; set; }
        public Type Type { get; set; }

        public Guid SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; } //navegation property 

        public virtual ICollection<Review> Reviews { get; set; }


    }
}
