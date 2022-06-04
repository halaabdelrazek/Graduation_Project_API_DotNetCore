﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Laptop:Product
    {
        public Laptop()
        {
            Reviews = new HashSet<Review>();
        }

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

        public Guid SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }
}
