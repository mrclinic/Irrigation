namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("LASERCOMMIT")]
    public partial class LASERCOMMIT : PARENTENTITY
    {
        //طلب تسوية بالليزر
        public LASERCOMMIT() {
            CREATION_DATE = DateTime.Now;

        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }

        public decimal LASERId { get; set; }

        [ForeignKey("LASERId")]
        public virtual LASERORDER LASERORDER { get; set; }

        public DateTime DONEDATE { get; set; }

        public string ESALNUM { get; set; }

        public DateTime ESALDAT { get; set; }

        public double ESALVAL { get; set; }
        public double ESALPOST { get; set; }
        public double ESALTOTAL { get; set; }


    }
}
