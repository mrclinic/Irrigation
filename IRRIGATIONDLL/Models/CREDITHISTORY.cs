namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("CREDITHISTORY")]
    public partial class CREDITHISTORY : PARENTENTITY
    {
        //تفاصيل الاعتمادات
        public CREDITHISTORY() {
            CREATION_DATE = DateTime.Now;
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف تفاصيل الاعتمادات )")]
        public decimal Id { get; set; }

        [DisplayName("السنة")]
        public int CYEAR { get; set; }

        [DisplayName("قيمة تفصيل الاعتماد")]
        public decimal CREDITVAL { get; set; }

        [DisplayName("المبالغ الفعلية")]
        public decimal ACTUALVAL { get; set; }

        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("الفرع المصدر")]
        public decimal SRCBRAId { get; set; }
        [ForeignKey("SRCBRAId")]
        public virtual BRANCH SRCBRANCH { get; set; }
        [DisplayName("الفرع الوجهة")]
        public decimal DSTBRAId { get; set; }
        [ForeignKey("DSTBRAId")]
        public virtual BRANCH DSTBRANCH { get; set; }
        [DisplayName("الاعتماد الأساسي")]
        public decimal CREDITId { get; set; }
        [ForeignKey("CREDITId")]
        public virtual CREDIT CREDIT { get; set; }

        [StringLength(500)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }
    }
}
