using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IRRIGATIONDLL.Models
{
    [Table("USER")]
    public partial class USER : PARENTENTITY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public string USERNAME { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public string AFIRSTNAME { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public string ALASTNAME { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public string PASSWORD { get; set; }
        public DateTime? CREATED { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public string GENDR { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public string LOCKED { get; set; }
        [Required]
        [DisplayName("«·«”„)")]
        public Nullable<int> DEPTNB { get; set; }
        [DisplayName("«·«”„)")]
        public Nullable<byte> SECURLEVEL { get; set; }

        public decimal? ROLEId { get; set; }
        [ForeignKey("ROLEId")]
        public virtual ROLE ROLE { get; set; }
    }
}
