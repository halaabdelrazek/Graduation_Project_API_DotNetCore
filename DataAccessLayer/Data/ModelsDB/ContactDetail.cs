using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class ContactDetail
    {
        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street1 { get; set; }
        public string? Street2 { get; set; }

        public  Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        public  string UserId { get; set; }
        public virtual User User { get; set; }


    }
}
