namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class BASEUNIT : PARENTENTITY
    {
        public BASEUNIT() {
            CREATION_DATE = DateTime.Now;
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف الوحدة الإدارية )")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("اسم الوحدة الإدارية ")]
        public string NAME { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("ترتيب الوحدة الإدارية ")]
        public string ORDER { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }
    }
}
