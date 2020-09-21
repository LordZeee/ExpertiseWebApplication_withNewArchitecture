using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbOrganizatsiya
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string tOrganizatsiya { get; set; }

        [StringLength(250)]
        public string tDescription { get; set; }

        [StringLength(250)]
        public string tNote { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys { get; set; }

        public virtual ICollection<tbExpertizy> tbExpertizys2 { get; set; }
    }
}
