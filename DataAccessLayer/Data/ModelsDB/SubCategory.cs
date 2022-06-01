using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class SubCategory
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }

        public Guid CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
