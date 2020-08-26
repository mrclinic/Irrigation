namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("BBRANCH")]
    public partial class BBRANCH : BASEUNIT
    {
        //فروع المصرف 
        public BBRANCH() {
            CREATION_DATE = DateTime.Now;
        }
        [Required]
        [StringLength(200)]
        [DisplayName("عنوان الفرع")]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("معلومات الاتصال")]
        public string CONTACTINFO { get; set; }

        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }
    }
}
