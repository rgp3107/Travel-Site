using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class City
    {
        public Guid CityId { get; set; }

        public string CityName { get; set; }
        public string CityImage { get; set; }

        public string CityDescription { get; set; }

        public Guid CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country country { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<CityImage> Images { get; set; }
    }
}
