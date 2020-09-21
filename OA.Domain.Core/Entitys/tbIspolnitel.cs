using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OA.Domain.Core.Entitys
{
    [Table("tbIspolnitel")]
    public class tbIspolnitel
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string tIspolnitel { get; set; }

        [StringLength(250)]
        public string tNote { get; set; }

        public bool? lActiv { get; set; }

        public int? nSort { get; set; }

        public int? nOtdelenie { get; set; }

        public virtual tbOtdelenie tbOtdelenie { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }

        public virtual ICollection<tbSoispolniteli> tbSoispolnitelis { get; set; }
    }
}
