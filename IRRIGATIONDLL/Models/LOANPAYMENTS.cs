namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("LOANPAYMENTS")]
    public partial class LOANPAYMENTS : PARENTENTITY
    {
        //أقساط القروض
        public LOANPAYMENTS() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف")]
        public decimal Id { get; set; }
        [DisplayName("رقم الدفعة")]
        public string PAYMENTNO { get; set; }

        [DisplayName("تاريخ")]
        public DateTime PAYMENTDATE { get; set; }

        [DisplayName("رقم القسط")]
        public string NO { get; set; }

        [DisplayName("تاريخ القسط")]
        public DateTime DAT { get; set; }

        [DisplayName("المستفيد")]
        public decimal BENEFICIALId { get; set; }
        [ForeignKey("BENEFICIALId")]
        public virtual BENEFICIAL BENEFICIAL { get; set; }

        [DisplayName("رقم طلب القرض")]
        public decimal LOANORDERId { get; set; }
        [ForeignKey("LOANORDERId")]
        public virtual LOANORDER LOANORDER { get; set; }
        [DisplayName("قيمة الدفعة")]
        public decimal PAYMENTVAL { get; set; }


    }
}
