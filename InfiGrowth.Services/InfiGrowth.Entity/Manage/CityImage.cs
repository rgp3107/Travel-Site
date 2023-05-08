using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class CityImage
    {
        public Guid ImageId { get; set; }

        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public Guid CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

    }
}
