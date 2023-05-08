using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Experience
    {
        public Guid ExperienceId { get; set; }

        public string ExperienceTitle { get; set; }

        public string ExperienceDescription { get; set; }

        public Guid CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
