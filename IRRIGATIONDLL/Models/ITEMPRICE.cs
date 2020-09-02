namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ITEMPRICE")]
    public partial class ITEMPRICE : PARENTENTITY
    {
        //اسعار المواد الربعية
        public ITEMPRICE() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف")]
        public decimal Id { get; set; }
        [DisplayName("الربع")]
        public int QUARTER { get; set; }

        [DisplayName("تاريخ النشرة)")]
        public DateTime DAT { get; set; }

        [DisplayName("السعر)")]
        public double PRICE { get; set; }        
        public virtual ITEMS ITEMS { get; set; }
    }
}
