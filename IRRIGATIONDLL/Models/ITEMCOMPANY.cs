﻿
namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ITEMCOMPANY")]
    public partial class ITEMCOMPANY : PARENTENTITY
    {
        //شركات المواد
        public ITEMCOMPANY() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [DisplayName("رمز المادة)")]
        public decimal ITMId { get; set; }

        [DisplayName("رمز الشركة)")]
        public decimal COMPId { get; set; }


        [DisplayName("مواصفات)")]
        public string DESCRIPTION { get; set; }


        [DisplayName("ملاحظات)")]
        public string NOTES { get; set; }
    }
}