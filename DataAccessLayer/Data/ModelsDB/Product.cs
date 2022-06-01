using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public abstract class  Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();

        }
        public Guid Id { get; set; }    

        public string Name { get; set; }

        public decimal Price { get; set; }

        [Range(1,5)]
        public decimal Rating { get; set; }

        public double Discount_Percent { get; set; }

        public int Avaiable_Units { get; set; }

        public string? Color { get; set; }

        public bool In_Stock  { get; set; }

        public double Weight { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        

        //public Guid CategoryId { get; set; }

        //public Category Category { get; set; }




    }
}
