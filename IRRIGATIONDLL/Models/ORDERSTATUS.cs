namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ORDERSTATUS")]
    public partial class ORDERSTATUS : PARENTENTITY
    {
        //حالات الطلب
        public ORDERSTATUS() {
            CREATION_DATE = DateTime.Now;

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        public int STATUS { get; set; }
        //تاريخ حصول الحالة
        public DateTime DONEDATE { get; set; }

        //ايدي الطلب بحسب النوع
        public decimal ORDERId { get; set; }

        //نوع الطلب قرض أو ليزر
        public decimal ORDERTYP { get; set; }

        [ForeignKey("ORDERTYP")]
        public virtual CONSTANT ORDER { get; set; }
    }
}
