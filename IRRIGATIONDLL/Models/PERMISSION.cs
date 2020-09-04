using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRRIGATIONDLL.Models
{

    [Table("PERMISSION")]
    public partial class PERMISSION : PARENTENTITY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string NAME { get; set; }
        public int? ORDR { get; set; }
        [Required]
        [StringLength(256)]
        public string DisplayName { get; set; }
    }
}
