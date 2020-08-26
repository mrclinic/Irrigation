namespace IRRIGATION.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("SECTION")]
    public partial class SECTION : BASEUNIT
    {
        //الشعبة
        public SECTION() {
            CREATION_DATE = DateTime.Now;
        }
        [Required]
        [StringLength(100)]
        [DisplayName("اسم المدير")]
        public string HEADNAME { get; set; }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("الفرع")]

        public decimal BRANCHId { get; set; }
        [ForeignKey("BRANCHId")]
        public virtual BRANCH BRANCH { get; set; }

        [DisplayName("الدائرة")]

        public decimal CIRCLEId { get; set; }
        [ForeignKey("CIRCLEId")]
        public virtual CIRCLE CIRCLE { get; set; }
    }
}
