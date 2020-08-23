namespace MANAGEMENTDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("BRANCH")]
    public partial class BRANCH : BASEUNIT
    {
        //الفروع 
        public BRANCH() {
            CREATION_DATE = DateTime.Now;
            CIRCLE = new HashSet<CIRCLE>();
        }
        [Required]
        [StringLength(100)]
        [DisplayName("اسم المدير")]
        public string HEADNAME { get; set; }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        public virtual ICollection<CIRCLE> CIRCLE { get; set; }
    }
}
