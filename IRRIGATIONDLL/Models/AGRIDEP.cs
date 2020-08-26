namespace IRRIGATION.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("AGRIDEP")]
    public partial class AGRIDEP : BASEUNIT
    {
        //دائرة زراعة  
        //Agriculture Department
        public AGRIDEP() {
            CREATION_DATE = DateTime.Now;
            AGRISEC = new HashSet<AGRISEC>();
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("مديرية زراعة")]

        public decimal AGRIDIRId { get; set; }
        [ForeignKey("AGRIDIRId")]
        public virtual AGRIDIR AGRIDIR { get; set; }

        public virtual ICollection<AGRISEC> AGRISEC { get; set; }
    }
}
