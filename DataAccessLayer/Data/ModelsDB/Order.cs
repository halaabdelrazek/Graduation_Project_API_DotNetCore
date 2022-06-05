using DataAccessLayer.Data.ModelsDB.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Order
    {
        public Order()
        {
  
            ProductOrders = new HashSet<ProductOrder>();
        }
        public Guid Id { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal Tax { get; set; }
        
        public OrderStatus OrderStatus { get; set; }

        public DateTime DeliverDate { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid CarrierId { get; set; }

        public Carrier Carrier { get; set; }

      
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }

        // Realtionship with contactdetails 1 to 1 
        public virtual ContactDetail ContactDetail { get; set; }

    }
}
