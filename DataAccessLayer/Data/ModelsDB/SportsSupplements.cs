﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class SportsSupplements : Product
    {
        public String? Flavour { get; set; }

        public string? Format { get; set; }

        public string? Dimensions { get; set; }

        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
