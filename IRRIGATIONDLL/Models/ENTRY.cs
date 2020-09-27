namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ENTRY")]
    public partial class ENTRY : PARENTENTITY
    {
        //القيود 
        public ENTRY() {
            CREATION_DATE = DateTime.Now;
            ENTRYDETAILS = new HashSet<ENTRYDETAILS>();
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        [Required]
        [StringLength(500)]
        [DisplayName("بيان القيد")]
        public string DescriPtion { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("رقم القيد")]
        public string NUM { get; set; }

        [Required]
        [StringLength(500)]
        [DisplayName("رقم تسلسلي القيد")]
        public string SEQ { get; set; }


        [DisplayName(" تاريخ القيد")]
        public DateTime DAT { get; set; }
        //BRANCH
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("المحافظة")]

        public decimal BRANCHId { get; set; }
        [ForeignKey("BRANCHId")]
        public virtual BRANCH BRANCH { get; set; }

        public virtual ICollection<ENTRYDETAILS> ENTRYDETAILS { get; set; }
    }
}
