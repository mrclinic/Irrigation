namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("CONSTANTINDEX")]
    public partial class CONSTANTINDEX : PARENTENTITY
    {
        public CONSTANTINDEX() {
            CREATION_DATE = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف الثوابت )")]
        public decimal Id { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("اسم الثابت ")]        
        public string NAME { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("نوع الثابت ")]
        public string TYPE { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("ترتيب الثابت ")]
        public string ORDER { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }
    }
}
