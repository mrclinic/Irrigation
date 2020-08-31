using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRRIGATIONDLL.Models
{

    [Table("ROLEPERMISSIONS")]
    public partial class ROLEPERMISSIONS
    {
        public ROLEPERMISSIONS()
        {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public decimal ROLEId { get; set; }
        [ForeignKey("ROLEId")]
        public virtual ROLE ROLE { get; set; }

        public decimal PERMISSIONId { get; set; }
        [ForeignKey("PERMISSIONId")]
        public virtual PERMISSION PERMISSION { get; set; }
    }
}
