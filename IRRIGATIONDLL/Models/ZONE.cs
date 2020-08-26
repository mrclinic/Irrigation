namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ZONE")]
    public partial class ZONE : BASEUNIT
    {
        //منطقة
        public ZONE() {
            CREATION_DATE = DateTime.Now;
            SIDE = new HashSet<SIDE>();
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        public virtual ICollection<SIDE> SIDE { get; set; }
    }
}
