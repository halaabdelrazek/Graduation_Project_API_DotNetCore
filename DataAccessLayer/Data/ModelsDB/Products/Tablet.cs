using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Tablet 
    {
        public Tablet()
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
        public Guid SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public string? OpreatingSystem { get; set; }
        public string? MemoryRAM { get; set; }
        public string? StorageCapacity { get; set; }
        public string? DisplayType { get; set; }
        public string? ScreenSize { get; set; }
        public string? CellularTechnology { get; set; }
        public int ModelYear { get; set; }
        public string? SIMCardSlotCount { get; set; }
        public string? Dimensions { get; set; }

        public virtual ICollection<ProductCart> ProductCarts { get; set; }

        public String UserId { get; set; }
        public virtual User User { get; set; }


    }
}
