namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ITEMS")]
    public partial class ITEMS : PARENTENTITY
    {
        //المواد
        public ITEMS() {
            
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }

        [DisplayName("الاسم)")]
        public string NAME { get; set; }

        [DisplayName("الرمز)")]
        public string COD { get; set; }


        [DisplayName("مواصفات)")]
        public string DESCRIPTION { get; set; }


        [DisplayName("ملاحظات)")]
        public string NOTES { get; set; }


        [DisplayName("تصنيف المادة")]
        public decimal CLASSYId { get; set; }
        [ForeignKey("CLASSYId")]
        public virtual CLASSY CLASSY { get; set; }
    }
}
