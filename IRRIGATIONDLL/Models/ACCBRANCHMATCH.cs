namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ACCBRANCHMATCH")]
    public partial class ACCBRANCHMATCH : PARENTENTITY
    {
        // مطابقة حساب فرع مصرف
        //Agriculture Directorate
        public ACCBRANCHMATCH() {
            CREATION_DATE = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [DisplayName("فروع المصرف")]
        public decimal BBRANCHId { get; set; }
        [ForeignKey("BBRANCHId")]
        public virtual BBRANCH BBRANCH { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("اسم الحساب")]
        public string AccountNAME { get; set; }
        [Required]
        [StringLength(200)]
        [DisplayName("رقم الحساب")]

        public string AccountNUM { get; set; }

        [DisplayName("تاريخ المطابقة")]
        public DateTime MATCHDATE { get; set; }
    }
}
