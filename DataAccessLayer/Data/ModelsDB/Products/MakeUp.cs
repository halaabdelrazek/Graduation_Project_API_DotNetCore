using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class MakeUp:Product
    {
        public string SkinTone { get; set; }
        public string SkinType { get; set; }
        public string Dimensions { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
