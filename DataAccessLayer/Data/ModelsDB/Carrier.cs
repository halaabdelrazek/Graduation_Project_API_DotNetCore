using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Carrier
    {
        public Carrier()
        {
            Products = new HashSet<Product>();
        }
        public Guid Id { get; set; }

        public string? Carrier_Name { get; set; }

        public string? Carrier_Phone { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
