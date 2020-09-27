namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("DECISION")]
    public partial class DECISION : PARENTENTITY
    {
        //القرارات الخاصة بالشركة
        public DECISION() {
            CREATION_DATE = DateTime.Now;
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }

        [DisplayName("تاريخ القرار)")]
        public DateTime DAT { get; set; }

        [StringLength(300)]
        [DisplayName("محتوى القرار")]
        public string BIAN { get; set; }

        [DisplayName("الشركة")]

        public decimal COMId { get; set; }
        [ForeignKey("COMId")]
        public virtual COMPANY COMPANY { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }        
    }
}
