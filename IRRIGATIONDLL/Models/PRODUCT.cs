namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("PRODUCT")]
    public partial class PRODUCT : PARENTENTITY
    {
        public PRODUCT() {
            CREATION_DATE = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف المنتج)")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(300)]
        [DisplayName("اسم المنتج")]
        public string NAME { get; set; }

        [DisplayName("نوع المنتج")]

        public decimal KINDId { get; set; }
        [ForeignKey("KINDId")]
        public virtual CONSTANT PRODUCTKIND { get; set; }

        [StringLength(500)]
        [DisplayName("ملاحظات")]
        public string NOTE { get; set; }
    }
}
