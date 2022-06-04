using DataAccessLayer.Data.ModelsDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor = DataAccessLayer.Data.ModelsDB.Monitor;

namespace DataAccessLayer.Data.Context
{
    public class DBContext:IdentityDbContext<User>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UsersClaims");
        }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Accessories> Accessories { get; set; }

        public DbSet<CardioEquipment> CardioEquipments { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<MakeUp> MakeUps { get; set; }
        public DbSet<MobilePhone> MobilePhones { get; set; }

        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<PCGaming> PCGamings { get; set; }
        public DbSet<Perfume> Perfumes { get; set; }
        public DbSet<ShoesSport> ShoesSports { get; set; }

        public DbSet<SportsSupplements> SportsSupplements { get; set; }
        public DbSet<Tablet> Tablets { get; set; }
        public DbSet<Review> Reviewes { get; set; }
    }
}
