namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("FINCOND")]
    public partial class FINCOND : PARENTENTITY
    {
        //جدول شروط أنواع التمويل
        public FINCOND() {
            CREATION_DATE = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف شرط أنواع التمويل)")]
        public decimal Id { get; set; }
        [Required]
        [StringLength(500)]
        [DisplayName("اسم شرط نوع التمويل ")]        
        public string NAME { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("ترتيب نوع التمويل")]
        public string ORDER { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }

        [DisplayName("نوع التمويل")]

        public decimal FINId { get; set; }
        [ForeignKey("FINId")]
        public virtual FINANCE FINANCE { get; set; }
    }
}
