using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class SubCategory
    {
        public SubCategory()
        {
            MobilePhones = new HashSet<MobilePhone>();
            Tablets = new HashSet<Tablet>();
        }
        public Guid ID { get; set; }
        public string? Name { get; set; }

        public Guid CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<MobilePhone> MobilePhones { get; set; }
        public virtual ICollection<Tablet> Tablets { get; set; }
    }
}
