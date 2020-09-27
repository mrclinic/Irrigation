namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("FINANCE")]
    public partial class FINANCE : PARENTENTITY
    {
        //جدول أنواع التمويل
        public FINANCE() {
            CREATION_DATE = DateTime.Now;
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف أنواع التمويل)")]
        public decimal Id { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("اسم نوع التمويل ")]        
        public string NAME { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("نسبة نوع التمويل")]
        public string TYPE { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("ترتيب نوع التمويل")]
        public string ORDER { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }
    }
}
