namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("GOVERNORATE")]
    public partial class GOVERNORATE : BASEUNIT
    {
        //محافظة
        public GOVERNORATE() {
            CREATION_DATE = DateTime.Now;
            ZONE = new HashSet<ZONE>();
            BRANCH = new HashSet<BRANCH>();
        }
        public virtual ICollection<ZONE> ZONE { get; set; }
        public virtual ICollection<BRANCH> BRANCH { get; set; }
    }
}
