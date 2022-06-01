using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Tablet
    {
        public string? OpreatingSystem { get; set; }
        public string? MemoryRAM { get; set; }
        public string? StorageCapacity { get; set; }
        public string? DisplayType { get; set; }
        public string? ScreenSize { get; set; }
        public string? CellularTechnology { get; set; }
        public int ModelYear { get; set; }
        public string? SIMCardSlotCount { get; set; }
        public string? Dimensions { get; set; }
        public Guid SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
