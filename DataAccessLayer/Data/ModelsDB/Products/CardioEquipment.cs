using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class CardioEquipment : Product
    {
        public string? Material { get; set; }

        public string? Dimensions { get; set; }

        public Guid SubCategoryId { get; set; }
        
        public virtual SubCategory SubCategory { get; set; }


    }
}
