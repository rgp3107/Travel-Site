using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Hotel
    {
        public Guid HotelId { get; set; }

        public Guid CityId { get;set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public string ?HotelName { get;set; }
        public string ?HotelImage { get; set; }
        public double ?HotelPrice {get; set; }
        public string ?HotelAddress { get; set; }
        public long ?PinCode { get;set; }

    }
}
