namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("BILLS")]
    public partial class BILLS : PARENTENTITY
    {
        //الفواتير
        public BILLS() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف")]
        public decimal Id { get; set; }
        [DisplayName("رقم")]
        public string BILLNO { get; set; }

        [DisplayName("تاريخ")]
        public string BILLDATE { get; set; }

        public decimal BENEFICIALId { get; set; }
        [ForeignKey("BENEFICIALId")]
        public virtual BENEFICIAL BENEFICIAL { get; set; }

        [DisplayName("رقم طلب القرض")]
        public decimal LOANORDERId { get; set; }
        [ForeignKey("LOANORDERId")]
        public virtual LOANORDER LOANORDER { get; set; }
        [DisplayName("قيمة الفاتورة")]
        public decimal TOTALVAL { get; set; }


    }
}
