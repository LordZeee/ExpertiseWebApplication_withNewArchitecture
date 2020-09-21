using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OA.Domain.Core.Entitys
{
    public class tbSoispolniteli
    {
        public int ID { get; set; }

        public int? nExpertiza { get; set; }

        public int? nIspolnitel { get; set; }

        public float? nTZ1 { get; set; }

        public float? nTZ2 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] upsize_ts { get; set; }

        public virtual tbIspolnitel tbIspolnitel { get; set; }

        public virtual tbExpertizy tbExpertizy { get; set; }
    }
}
