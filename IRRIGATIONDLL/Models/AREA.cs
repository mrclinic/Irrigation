namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("AREA")]
    public partial class AREA : BASEUNIT
    {
        //المناطق العقارية
        public AREA() {
            CREATION_DATE = DateTime.Now;
            //SIDE = new HashSet<SIDE>();
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        //public virtual ICollection<SIDE> SIDE { get; set; }
    }
}
