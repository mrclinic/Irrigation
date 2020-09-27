namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("CREDIT")]
    public partial class CREDIT : PARENTENTITY
    {
        //الاعتمادات 
        public CREDIT() {
            CREATION_DATE = DateTime.Now;
            CREDITHISTORY = new HashSet<CREDITHISTORY>();
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف الاعتمادات )")]
        public decimal Id { get; set; }

        [DisplayName("السنة")]
        public int CYEAR { get; set; }

        [DisplayName("قيمة الاعتماد")]
        public decimal CREDITVAL { get; set; }


        [Required]
        [StringLength(100)]
        [DisplayName("المساحة المخططة")]
        public string PLANAREA { get; set; }


        [Required]
        [StringLength(100)]
        [DisplayName("المساحة المنفذة")]
        public string ACTUALAREA { get; set; }

        [DisplayName("المبالغ الفعلية")]
        public decimal ACTUALVAL { get; set; }

        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("الفرع")]
        public decimal BRAId { get; set; }
        [ForeignKey("BRAId")]
        public virtual BRANCH BRANCH { get; set; }

        [StringLength(500)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }

        public virtual ICollection<CREDITHISTORY> CREDITHISTORY { get; set; }
    }
}
