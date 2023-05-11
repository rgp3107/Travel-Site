using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public Guid HotelId { get; set; }
        [ForeignKey("HotelId")]
        //public virtual Hotel Hotel { get; set; }
        public Guid BillingId { get; set; }
        [ForeignKey("BillingId")]
        public virtual Billing Billing { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set;}

    }
}
