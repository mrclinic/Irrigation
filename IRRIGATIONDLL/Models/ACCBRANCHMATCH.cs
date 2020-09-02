namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ACCBRANCHMATCH")]
    public partial class ACCBRANCHMATCH : BASEUNIT
    {
        // مطابقة حساب فرع مصرف
        //Agriculture Directorate
        public ACCBRANCHMATCH() {
            CREATION_DATE = DateTime.Now;
        }
        [DisplayName("فروع المصرف")]
        public decimal BBRANCHId { get; set; }
        [ForeignKey("BBRANCHId")]
        public virtual BBRANCH BBRANCH { get; set; }

        [DisplayName("حساب المصرف")]
        [Required]
        public string ACCId { get; set; }

        [DisplayName("الشخص الذي قام بالمطابقة مع المصرف")]

        public decimal USERId { get; set; }
        [ForeignKey("USERId")]
        public virtual USER USER { get; set; }
        [DisplayName("تاريخ المطابقة")]
        public DateTime MATCHDATE { get; set; }
    }
}
