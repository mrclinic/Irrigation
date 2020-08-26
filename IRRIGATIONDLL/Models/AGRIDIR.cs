namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("AGRIDIR")]
    public partial class AGRIDIR : BASEUNIT
    {
        //مديرية زراعة 
        //Agriculture Directorate
        public AGRIDIR() {
            CREATION_DATE = DateTime.Now;
            AGRIDEP = new HashSet<AGRIDEP>();
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        public virtual ICollection<AGRIDEP> AGRIDEP { get; set; }
    }
}
