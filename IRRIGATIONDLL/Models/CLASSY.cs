namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("CLASSY")]
    public partial class CLASSY : PARENTENTITY
    {
        //تصنيفات تجهيزات شبكات الري الحديث
        public CLASSY() {
            CREATION_DATE = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [Required]
        [StringLength(200)]
        [DisplayName("اسم الصنف")]
        public string NAME { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("رمز الصنف")]
        public string CODE { get; set; }

        [DisplayName("سعر الصنف")]

        public decimal PRICE { get; set; }

        [DisplayName("الصنف الأب")]

        public decimal PARENTId { get; set; }
        [ForeignKey("PARENTId")]
        public virtual CLASSY PARENT { get; set; }

        [InverseProperty("Parent")]
        public virtual ICollection<CLASSY> InverseParent { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("مواصفات الصنف")]
        public string DESCRIPTION { get; set; }
    }
}
