namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("BILLITEMS")]
    public partial class BILLITEMS : PARENTENTITY
    {
        //مواد الفاتورة
        public BILLITEMS() {
            
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف")]
        public decimal Id { get; set; }
        [DisplayName("رقم الفاتورة")]
        public decimal BILLId { get; set; }
        [ForeignKey("BILLId")]
        public virtual BILLS BILLS { get; set; }

        [DisplayName("بيان المادة")]
        public decimal ITEMId { get; set; }
        [ForeignKey("ITEMId")]
        public virtual ITEMS ITEMS { get; set; }

        [DisplayName("المصدر")]
        public decimal COMPId { get; set; }
        [ForeignKey("COMPId")]
        public virtual COMPANY COMPANY { get; set; }

        [DisplayName("الواحدة")]
        public string UNIT { get; set; }

        [DisplayName("الكمية")]
        public decimal COUNT { get; set; }

    }
}
