using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal Tax { get; set; }
        
        public OrderStatus OrderStatus { get; set; }

        public DateTime DeliverDate { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid CarrierId { get; set; }

        public Carrier Carrier { get; set; }



    }
}
