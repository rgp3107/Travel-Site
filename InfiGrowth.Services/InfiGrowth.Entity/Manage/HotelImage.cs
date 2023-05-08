using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class HotelImage
    {
        public Guid HotelImageId {  get; set; }
        public Guid HotelId { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }    
        public string ImageUrl { get; set; }
        public string ImageName { get; set; } = string.Empty;
    }
}
