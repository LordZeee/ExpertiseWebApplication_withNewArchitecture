using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OA.Domain.Core.Entitys
{
    public class tbOtdelenie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string tOtdelenie { get; set; }

        [StringLength(50)]
        public string tFIO { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }

        public virtual ICollection<tbIspolnitel> tbIspolnitels { get; set; }
    }
}
