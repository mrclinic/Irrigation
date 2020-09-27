using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRRIGATIONDLL.Models
{

    [Table("ROLE")]
    public partial class ROLE : PARENTENTITY
    {
        public ROLE()
        {
            USERS = new HashSet<USER>();
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string NAME { get; set; }
        public int? ORDR { get; set; }

        public virtual ICollection<USER> USERS { get; set; }
    }
}
