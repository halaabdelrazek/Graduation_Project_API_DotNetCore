using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ProductOrder
    {

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }


    }
}
