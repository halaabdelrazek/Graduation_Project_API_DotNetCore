using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Monitor:Product
    {
        public string ScreenSize { get; set; }
        public string RefreshRate { get; set; }

        public Guid SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
