namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("COMPANY")]
    public partial class COMPANY : PARENTENTITY
    {
        //الشركة
        public COMPANY() {
            CREATION_DATE = DateTime.Now;
            SANCTION = new HashSet<SANCTION>();
            DECISION = new HashSet<DECISION>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف الشركة)")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(300)]
        [DisplayName("اسم الشركة")]
        public string NAME { get; set; }

        [DisplayName("صفة الشركة")]

        public decimal ADJId { get; set; }
        [ForeignKey("ADJId")]
        public virtual CONSTANT ADJECTIVE { get; set; }

        [DisplayName("نوع السجل")]

        public decimal STRId { get; set; }
        [ForeignKey("STRId")]
        public virtual CONSTANT STRUCTTYPE { get; set; }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }
        [Required]
        [StringLength(300)]
        [DisplayName("العنوان")]
        public string ADDRESS { get; set; }

        [DisplayName("رقم الهاتف/أرضي")]
        [StringLength(30)]
        public string PHONE { get; set; }

        [DisplayName("رقم الهاتف/موبايل")]
        [StringLength(30)]
        public string MOBILE { get; set; }

        [DisplayName("رقم فاكس")]
        [StringLength(30)]
        public string FAX { get; set; }

        [DisplayName("حالة الشركة")]
        public decimal STAId { get; set; }
        [ForeignKey("STAId")]
        public virtual CONSTANT STATUS { get; set; }

        [StringLength(300)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }

        public ICollection<SANCTION> SANCTION { get; set; }

        public ICollection<DECISION> DECISION { get; set; }
    }
}
