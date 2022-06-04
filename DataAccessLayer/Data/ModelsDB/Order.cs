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
            Laptops = new HashSet<Laptop>();
            PCGamings = new HashSet<PCGaming>();
            Monitors = new HashSet<Monitor>();
            Accessories = new HashSet<Accessories>();
            CardioEquipments = new HashSet<CardioEquipment>();
            SportsSupplements = new HashSet<SportsSupplements>();
            ShoesSports = new HashSet<ShoesSport>();

            Perfume = new HashSet<Perfume>();
            MakeUp = new HashSet<MakeUp>();
            MobilePhones = new HashSet<MobilePhone>();
            Tablets = new HashSet<Tablet>();
        }
        public Guid Id { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal Tax { get; set; }
        
        public OrderStatus OrderStatus { get; set; }

        public DateTime DeliverDate { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid CarrierId { get; set; }

        public Carrier Carrier { get; set; }

        public virtual ICollection<Laptop> Laptops { get; set; }
        public virtual ICollection<PCGaming> PCGamings { get; set; }
        public virtual ICollection<Monitor> Monitors { get; set; }
        public virtual ICollection<Accessories> Accessories { get; set; }
        public virtual ICollection<MakeUp> MakeUp { get; set; }
        public virtual ICollection<Perfume> Perfume { get; set; }

        public virtual ICollection<CardioEquipment> CardioEquipments { get; set; }
        public virtual ICollection<SportsSupplements> SportsSupplements { get; set; }

        public virtual ICollection<ShoesSport> ShoesSports { get; set; }

        public virtual ICollection<MobilePhone> MobilePhones { get; set; }
        public virtual ICollection<Tablet> Tablets { get; set; }


        // Realtionship with contactdetails 1 to 1 
        public virtual ContactDetail ContactDetail { get; set; }

    }
}
