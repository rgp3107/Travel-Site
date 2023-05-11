using InfiGrowth.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Models.Dto
{
    public class BookingRequest
    {
        public Guid BookingId { get; set; }
        public Guid HotelId { get; set; }
      
        public Guid BillingId { get; set; }
        public DateTime CheckIn { get; set; } 
        public DateTime CheckOut { get; set; }
    }
}
