using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.ModelsDB
{
    public class Review
    {
        public Guid Id { get; set; }
        public string? ReviewText { get; set; }

        public DateTime ReviewDate { get; set; }


        [Range(1, 5)]
        public int Rating { get; set; }

        public String UserId { get; set; }

        public virtual User User { get; set; }





    }
}
