using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Laptop
    {
        public Laptop()
        {
            ProductImages = new HashSet<ProductImage>();
            WishlistProduct = new HashSet<WishlistProduct>();
            ProductOrders = new HashSet<ProductOrder>();
            Reviews = new HashSet<Review>();
            ProductCarts = new HashSet<ProductCart>();
        }
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [Range(1, 5)]
        public decimal Rating { get; set; }

        public double Discount_Percent { get; set; }

        public int Avaiable_Units { get; set; }

        public string? Color { get; set; }

        public bool In_Stock { get; set; }

        public double Weight { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public virtual ICollection<WishlistProduct> WishlistProduct { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<ProductCart> ProductCarts { get; set; }

        public Guid SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public string ScreenSize { get; set; }

        public string MemorySpeed { get; set; }

        public string? CPUModel { get; set; }

        public string OS { get; set; }

        public string CPUSpeed { get; set; }

        public string? SSDSize { get; set; }

        public string? HDDSize { get; set; }

        public int? TotalUSBPorts { get; set; }

        public int ProcessorCount { get; set; }
        public string? CPU { get; set; }
        public string GraphicsCard { get; set; }

        public String UserId { get; set; }
        public virtual User User { get; set; }

    }
}
