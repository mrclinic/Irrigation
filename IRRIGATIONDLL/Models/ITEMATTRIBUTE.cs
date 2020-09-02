namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ITEMATTRIBUTE")]
    public partial class ITEMATTRIBUTE : PARENTENTITY
    {
        //المواد
        public ITEMATTRIBUTE() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [DisplayName("قيمة الواصفة)")]
        public string VAL { get; set; }

        [DisplayName("الواصفة")]

        public decimal ATTRIBUTESId { get; set; }
        [ForeignKey("ATTRIBUTESId")]
        public virtual ATTRIBUTES ATTRIBUTES { get; set; }

        [DisplayName("المادة")]

        public decimal ITEMSId { get; set; }
        [ForeignKey("ITEMSId")]
        public virtual ITEMS ITEMS { get; set; }

        //واحدة القياس
        public decimal UNITId { get; set; }
        [ForeignKey("UNITId")]
        public virtual CONSTANT UNIT { get; set; }

        [DisplayName("سعر المادة مع مواصفاتها")]
        //عبارة عن مصفوفة من الواصفات مع السعر

        public decimal ITEMPRICEId { get; set; }
        [ForeignKey("ITEMPRICEId")]
        public virtual ITEMPRICE ITEMPRICE { get; set; }
    }
}
