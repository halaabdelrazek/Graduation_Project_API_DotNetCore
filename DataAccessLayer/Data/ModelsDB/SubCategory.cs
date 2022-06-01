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
            Laptops = new HashSet<Laptop>();
            PCGamings = new HashSet<PCGaming>();
            Monitors = new HashSet<Monitor>();
            Accessories = new HashSet<Accessories>();


        }
        public Guid ID { get; set; }
        public string? Name { get; set; }

        public Guid CategoryID { get; set; }

        public virtual Category Category { get; set; }


        public virtual ICollection<Laptop> Laptops { get; set; }
        public virtual ICollection<PCGaming> PCGamings { get; set; }
        public virtual ICollection<Monitor> Monitors { get; set; }
        public virtual ICollection<Accessories> Accessories { get; set; }





    }
}
