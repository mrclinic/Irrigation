namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ATTRIBUTES")]
    public partial class ATTRIBUTES : PARENTENTITY
    {
        //المواد
        public ATTRIBUTES() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [DisplayName("الاسم)")]
        public string NAME { get; set; }
    }
}
