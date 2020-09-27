namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ENTRYDETAILS")]
    public partial class ENTRYDETAILS : PARENTENTITY
    {
        //القيود 
        public ENTRYDETAILS() {
            CREATION_DATE = DateTime.Now;
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [Required]
        [StringLength(500)]
        [DisplayName("البيان")]
        public string DescriPtion { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("اسم الحساب")]
        public string AccountNAME { get; set; }
        [Required]
        [StringLength(200)]
        [DisplayName("رقم الحساب")]

        public string AccountNUM { get; set; }

        [DisplayName("التاريخ")]
        public DateTime DAT { get; set; }
        //BRANCH
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("فرع المصرف")]

        public decimal BRANCHId { get; set; }
        [ForeignKey("BRANCHId")]
        public virtual BRANCH BRANCH { get; set; }

        [DisplayName("القيد")]

        public decimal ENTRYId { get; set; }
        [ForeignKey("ENTRYId")]
        public virtual ENTRY ENTRY { get; set; }
        [DisplayName("مدين")]
        public decimal CREDIT { get; set; }
        [DisplayName("دائن")]
        public decimal DEBIT { get; set; }

        [DisplayName("مطابق؟")]
        public bool? ISMATCHED { get; set; }
        [DisplayName("تاريخ المطابقة")]
        public DateTime? MATCHDAT { get; set; }
    }
}
