using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbNapravlenieER
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string tNapravlenieER { get; set; }

        [StringLength(250)]
        public string tNote { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }
    }
}
