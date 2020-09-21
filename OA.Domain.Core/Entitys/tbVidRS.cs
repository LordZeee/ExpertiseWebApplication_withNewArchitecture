using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbVidRS
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string tVidRS { get; set; }

        [StringLength(250)]
        public string tNote { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }
    }
}
