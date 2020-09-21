using System.ComponentModel.DataAnnotations;

namespace OA.Domain.Core.Entitys
{
    public class tbRamDogovor
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string tRamDogovor { get; set; }

        public double? nSummaRD { get; set; }

        public bool? lRDClose { get; set; }
    }
}
