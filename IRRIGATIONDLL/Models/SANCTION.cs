namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("SANCTION")]
    public partial class SANCTION : PARENTENTITY
    {
        //العقوبات الخاصة بالشركة
        public SANCTION() {
            CREATION_DATE = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }

        [DisplayName("تاريخ العقوبة)")]
        public DateTime DAT { get; set; }

        [StringLength(300)]
        [DisplayName("محتوى العقوبة")]
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
