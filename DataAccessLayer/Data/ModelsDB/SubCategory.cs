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
            CardioEquipments = new HashSet<CardioEquipment>();
            SportsSupplements = new HashSet<SportsSupplements>();
            ShoesSports = new HashSet<ShoesSport>();

            MobilePhones = new HashSet<MobilePhone>();
            Tablets = new HashSet<Tablet>();

        }
     
        public Guid ID { get; set; }
        public string? Name { get; set; }

        public Guid CategoryID { get; set; }

        public virtual Category Category { get; set; }


        public virtual ICollection<Laptop> Laptops { get; set; }
        public virtual ICollection<PCGaming> PCGamings { get; set; }
        public virtual ICollection<Monitor> Monitors { get; set; }
        public virtual ICollection<Accessories> Accessories { get; set; }

        public virtual ICollection<CardioEquipment> CardioEquipments { get; set; }
        public virtual ICollection<SportsSupplements> SportsSupplements { get; set; }

        public virtual ICollection<ShoesSport> ShoesSports { get; set; }

        public virtual ICollection<MobilePhone> MobilePhones { get; set; }
        public virtual ICollection<Tablet> Tablets { get; set; }
    }
}
