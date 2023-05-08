using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Country
    {
        public Guid CountryId { get; set; }

        public string ?CountryName { get; set; }

        public string ?CountryCode { get; set; }
    }
}
