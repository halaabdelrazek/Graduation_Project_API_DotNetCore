using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class User: IdentityUser
    {
        User()
        {
            ContactDetails = new HashSet<ContactDetail>();
        }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Company_Name { get; set; }
        public decimal? Avarage_Rateing { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public Guid CartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }

    }
}
