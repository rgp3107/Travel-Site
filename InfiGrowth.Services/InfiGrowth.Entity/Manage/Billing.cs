using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Billing
    {
        public Guid BillingId { get; set; }
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        
        public DateTime Date { get; set; }
        public string PaymentType { get;set; }
        public double Tax { get; set; } = 500;
        public double TotalPrice { get; set; }
    }
}
