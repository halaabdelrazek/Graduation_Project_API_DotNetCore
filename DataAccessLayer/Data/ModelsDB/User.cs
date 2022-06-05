﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class User: IdentityUser
    {
        User()
        {
            ContactDetails = new HashSet<ContactDetail>();
            Reviews = new HashSet<Review>();
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

      
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Company_Name { get; set; }
        public decimal? Avarage_Rateing { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }



        //public Guid ShoppingCartId { get; set; }
        //public virtual ShoppingCart ShoppingCart { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        //public virtual Wishlist Wishlist { get; set; }


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

 

    }
}
