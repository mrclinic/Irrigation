﻿namespace MANAGEMENTDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class HEADENTITY
    {
        [Required]
        [StringLength(100)]
        [DisplayName("اسم المدير")]
        public string HEADNAME { get; set; }
    }
}
