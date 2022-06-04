using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ShoesSport : Product
    {
        public int Size { get; set; }
        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
