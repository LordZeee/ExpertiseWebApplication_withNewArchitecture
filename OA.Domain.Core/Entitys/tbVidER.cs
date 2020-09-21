using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbVidER
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string tVidER { get; set; }

        [StringLength(250)]
        public string tNote { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }
    }
}
