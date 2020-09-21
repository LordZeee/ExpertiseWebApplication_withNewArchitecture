using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbStatusE
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string tStatusE { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }
    }
}
