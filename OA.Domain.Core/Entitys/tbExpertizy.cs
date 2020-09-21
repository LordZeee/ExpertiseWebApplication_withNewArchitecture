using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OA.Domain.Core.Entitys
{
    [Table("tbExpertizy")]
    public class tbExpertizy
    {
        public int ID { get; set; }

        public int? N1 { get; set; }

        public int? N2 { get; set; }

        public int? N3 { get; set; }

        public int? nZayavitel { get; set; }

        public int? nZakazchik { get; set; }

        public int? nOtdelenie { get; set; }

        public int? nIspolnitel { get; set; }

        public int? nVidRS { get; set; }

        public int? nNapravlenieER { get; set; }

        public int? nTipDogovora { get; set; }

        public int? nIndexVD { get; set; }

        public int? nVidER { get; set; }

        public int? nStatusE { get; set; }

        public int? nStatusD { get; set; }

        [StringLength(50)]
        public string tLetterZak { get; set; }

        public DateTime? dLetterZak { get; set; }

        [StringLength(50)]
        public string tLetterZayav { get; set; }

        public DateTime? dLetterZayav { get; set; }

        [StringLength(50)]
        public string tLetterP { get; set; }

        public DateTime? dLetterP { get; set; }

        [StringLength(50)]
        public string tPrikaz { get; set; }

        public DateTime? dPrikaz { get; set; }

        public DateTime? dTermZayav { get; set; }

        public DateTime? dTermIspol { get; set; }

        public DateTime? dTermCorrect { get; set; }

        public DateTime? dTermLimit { get; set; }

        public double? nDuration { get; set; }

        [StringLength(4000)]
        public string mTitleDoc { get; set; }

        [StringLength(50)]
        public string tDogovor { get; set; }

        public DateTime? dDogovor { get; set; }

        [StringLength(50)]
        public string tDogovorO { get; set; }

        public DateTime? dDogovorO { get; set; }

        [StringLength(50)]
        public string tDogovorP { get; set; }

        public DateTime? dDogovorP { get; set; }

        [StringLength(50)]
        public string tProtocolR { get; set; }

        public DateTime? dProtocolR { get; set; }

        [StringLength(50)]
        public string tProtocolU { get; set; }

        public DateTime? dProtocolU { get; set; }

        [StringLength(50)]
        public string tCoordinationPU { get; set; }

        public DateTime? dCoordinationPU { get; set; }

        [StringLength(50)]
        public string tDopAgreement { get; set; }

        public DateTime? dDopAgreement { get; set; }

        [StringLength(50)]
        public string tLetterDopAgreement { get; set; }

        public DateTime? dLetterDopAgreement { get; set; }

        public double? nSumma { get; set; }

        public double? nSummaP { get; set; }

        public DateTime? dSummaP { get; set; }

        public bool? lSummaP { get; set; }

        [StringLength(50)]
        public string tEZP { get; set; }

        public DateTime? dEZP { get; set; }

        [StringLength(4000)]
        public string mNoteO1 { get; set; }

        [StringLength(1000)]
        public string mNoteO11 { get; set; }

        [StringLength(50)]
        public string tAct { get; set; }

        [StringLength(50)]
        public string tActO { get; set; }

        public DateTime? dActO { get; set; }

        [StringLength(50)]
        public string tActP { get; set; }

        public DateTime? dActP { get; set; }

        [StringLength(1000)]
        public string mNoteO2 { get; set; }

        [StringLength(50)]
        public string tTitleEZ { get; set; }

        [StringLength(50)]
        public string tNumEZ { get; set; }

        [StringLength(50)]
        public string tReportEZ { get; set; }

        public DateTime? dReportEZ { get; set; }

        [StringLength(50)]
        public string tDownload { get; set; }

        [StringLength(50)]
        public string tDownloadZ { get; set; }

        [StringLength(50)]
        public string tDownloadV { get; set; }

        [StringLength(50)]
        public string tDownloadL1 { get; set; }

        [StringLength(50)]
        public string tDownloadL2 { get; set; }

        [StringLength(50)]
        public string tDownloadL3 { get; set; }

        [StringLength(50)]
        public string tDownloadL4 { get; set; }

        [StringLength(50)]
        public string tDownloadL5 { get; set; }

        [StringLength(50)]
        public string tDownloadTZ { get; set; }

        public short? Work { get; set; }

        [StringLength(1000)]
        public string mNoteR { get; set; }

        [StringLength(250)]
        public string mNoteK { get; set; }

        [StringLength(1000)]
        public string mComment { get; set; }

        public DateTime? dCommentO { get; set; }

        public DateTime? dCommentP { get; set; }

        public bool? lAttention { get; set; }

        public bool? lEnd { get; set; }

        public bool? lClose { get; set; }

        public bool? lArchive { get; set; }
        public bool lPaused { get; set; }
        public bool? lView { get; set; }

        public float? nTZ { get; set; }

        public float? nTZ1 { get; set; }

        public float? nTZ2 { get; set; }

        public DateTime? dNalogovaya { get; set; }

        [StringLength(50)]
        public string tPerformer { get; set; }

        [StringLength(50)]
        public string tUzg { get; set; }

        public DateTime? dUzg { get; set; }

        public int? nSED { get; set; }

        public int? nSEDTZ { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] upsize_ts { get; set; }
        public virtual tbOrganizatsiya tbOrganizatsiya { get; set; }
        public virtual tbOrganizatsiya tbOrganizatsiyaZak { get; set; }
        public virtual tbOtdelenie tbOtdelenie { get; set; }
        public virtual tbIspolnitel tbIspolnitel { get; set; }
        public virtual tbNapravlenieER tbNapravlenieER { get; set; }
        public virtual tbIndexVD tbIndexVD { get; set; }
        public virtual tbVidRS tbVidRS { get; set; }
        public virtual tbVidER tbVidER { get; set; }
        public virtual tbStatusE tbStatusE { get; set; }
        public virtual tbStatusD tbStatusD { get; set; }
        public virtual tbTipDogovora tbTipDogovora { get; set; }

        public virtual ICollection<tbSoispolniteli> tbSoispolnitelis { get; set; }
    }
}
