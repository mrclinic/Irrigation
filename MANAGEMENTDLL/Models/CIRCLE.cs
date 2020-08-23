namespace MANAGEMENTDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("CIRCLE")]
    public partial class CIRCLE : BASEUNIT
    {
        //الدوائر
        public CIRCLE() {
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

        [DisplayName("المنطقة")]

        public decimal BRANCHId { get; set; }
        [ForeignKey("BRANCHId")]
        public virtual BRANCH BRANCH { get; set; }
    }
}
