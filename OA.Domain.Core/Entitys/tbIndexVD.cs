using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OA.Domain.Core.Entitys
{
    [Table("tbIndexVD")]
    public class tbIndexVD
    {
        public int ID { get; set; }

        [Required]
        //[Display(Name = "Вид діяльності")]
        [StringLength(250)]
        public string tIndexVD { get; set; }

        //[Display(Name = "Опис")]
        [StringLength(250)]
        public string tNote { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }
    }
}
