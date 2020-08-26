namespace IRRIGATION.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("SIDE")]
    public partial class SIDE : BASEUNIT
    {
        //ناحية
        public SIDE() {
            CREATION_DATE = DateTime.Now;
            VILLAGE = new HashSet<VILLAGE>();
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("المنطقة")]

        public decimal ZONEId { get; set; }
        [ForeignKey("ZONEId")]
        public virtual ZONE ZONE { get; set; }

        public virtual ICollection<VILLAGE> VILLAGE { get; set; }
    }
}
