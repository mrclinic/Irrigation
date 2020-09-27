namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("LASERORDER")]
    public partial class LASERORDER : PARENTENTITY
    {
        //طلب تسوية بالليزر
        public LASERORDER() {
            CREATION_DATE = DateTime.Now;

        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        public string ORDERNUM { get; set; }
        public DateTime ORDERDATE { get; set; }

        public decimal DOCSTYPEId { get; set; }
        [ForeignKey("DOCSTYPEId")]
        public virtual DOCTYPES DOCTYPES { get; set; }

        public decimal BENEFICIALId { get; set; }
        [ForeignKey("BENEFICIALId")]
        public virtual BENEFICIAL BENEFICIAL { get; set; }

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        public decimal VILLAGEId { get; set; }
        [ForeignKey("VILLAGEId")]
        public virtual VILLAGE VILLAGE { get; set; }

        public decimal CIRCLEId { get; set; }
        [ForeignKey("CIRCLEId")]
        public virtual CIRCLE CIRCLE { get; set; }

        public decimal INDICId { get; set; }
        [ForeignKey("INDICId")]
        public virtual INDIC INDIC { get; set; }


        public decimal SIDEId { get; set; }
        [ForeignKey("SIDEId")]
        public virtual SIDE SIDE { get; set; }


        public decimal ZONEId { get; set; }
        [ForeignKey("ZONEId")]
        public virtual ZONE ZONE { get; set; }

        
        public decimal BBRANCHId { get; set; }
        [ForeignKey("BBRANCHId")]
        public virtual BBRANCH BBRANCH { get; set; }



        //المصدر المائي
        public decimal IRRIGATIONRESOURCEId { get; set; }
        [ForeignKey("IRRIGATIONRESOURCEId")]
        public virtual CONSTANT IRRIGATIONRESOURCE { get; set; }

        public string LICENCENUM { get; set; }
        public string LICENCEDATE { get; set; }
        public string LICENCEOWNER { get; set; }

        public string LICENCETOTALAREA { get; set; }

        public string REALESTATENUM { get; set; }


        public decimal AREAId { get; set; }
        [ForeignKey("AREAId")]
        public virtual AREA AREA { get; set; }

        public string PLANETTYPE { get; set; }

       //عدد الوثائق المرفقة
        public decimal DOCSCOUNT { get; set; }


    }
}
