using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbTipDogovora
    {
        public int ID { get; set; }

        [StringLength(3)]
        public string tTipDogovora { get; set; }

        [StringLength(250)]
        public string tNote { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }
    }
}
