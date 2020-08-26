﻿namespace IRRIGATION.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("VILLAGE")]
    public partial class VILLAGE : BASEUNIT
    {
        //قرية
        public VILLAGE() {
            CREATION_DATE = DateTime.Now;
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("المنطقة")]

        public decimal ZONEId { get; set; }
        [ForeignKey("ZONEId")]
        public virtual ZONE ZONE { get; set; }
        [DisplayName("الناحية")]
        public decimal SIDEId { get; set; }
        [ForeignKey("SIDEId")]
        public virtual SIDE SIDE { get; set; }
    }
}
