using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ProductCart
    {
        public Guid Id { get; set; }
        public Guid ShoppingCartId { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Guid AccessoriesId { get; set; }

        public virtual Accessories Accessories { get; set; }

        public Guid CardioEquipmentId { get; set; }


        public virtual CardioEquipment CardioEquipment { get; set; }

        public Guid LaptopId { get; set; }

        public virtual Laptop Laptop { get; set; }


        public Guid MakeUpId { get; set; }

        public virtual MakeUp MakeUp { get; set; }


        public Guid MobilePhoneId { get; set; }

        public virtual MobilePhone MobilePhone { get; set; }


        public Guid MonitorId { get; set; }

        public virtual Monitor Monitor { get; set; }
        public Guid PCGamingId { get; set; }

        public virtual PCGaming PCGaming { get; set; }

        public Guid PerfumeId { get; set; }

        public virtual Perfume Perfume { get; set; }


        public Guid ShoesSportId { get; set; }

        public virtual ShoesSport ShoesSport { get; set; }


        public Guid SportsSupplementsId { get; set; }

        public virtual SportsSupplements SportsSupplements { get; set; }

        public Guid TabletId { get; set; }

        public virtual Tablet Tablet { get; set; }
    }
}
