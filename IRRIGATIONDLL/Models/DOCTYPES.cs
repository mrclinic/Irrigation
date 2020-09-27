namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("DOCTYPES")]
    public partial class DOCTYPES : PARENTENTITY
    {
        //أنواع الاستمارات
        public DOCTYPES() {
            
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [Required]
        [DisplayName("الاسم)")]
        public string NAME { get; set; }

    }
}
