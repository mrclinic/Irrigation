namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("SETTING")]
    public partial class SETTING : PARENTENTITY
    {
        public SETTING() {
            CREATION_DATE = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف الضبط )")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("اسم حقل الضبط ")]
        public string NAME { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("عنوان حقل الضبط ")]
        public string TITLE { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("قيمة حقل الضبط")]
        public string VALUE { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }
    }
}
