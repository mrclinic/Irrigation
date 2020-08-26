namespace IRRIGATION.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("AGRISEC")]
    public partial class AGRISEC : BASEUNIT
    {
        //شعبة في دائرة زراعة  
        //Agriculture Department
        public AGRISEC() {
            CREATION_DATE = DateTime.Now;
            //CIRCLE = new HashSet<CIRCLE>();
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("مديرية زراعة")]

        public decimal AGRIDIRId { get; set; }
        [ForeignKey("AGRIDIRId")]
        public virtual AGRIDIR AGRIDIR { get; set; }

        [DisplayName("دائرة زراعة")]

        public decimal AGRIDEPId { get; set; }
        [ForeignKey("AGRIDEPId")]
        public virtual AGRIDEP AGRIDEP { get; set; }

        [DisplayName("المنطقة")]

        public decimal ZONEId { get; set; }
        [ForeignKey("ZONEId")]
        public virtual ZONE ZONE { get; set; }
        [DisplayName("الناحية")]
        public decimal SIDEId { get; set; }
        [ForeignKey("SIDEId")]
        public virtual SIDE SIDE { get; set; }

        //public virtual ICollection<CIRCLE> CIRCLE { get; set; }
    }
}
