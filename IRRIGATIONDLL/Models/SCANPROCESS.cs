using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRRIGATIONDLL.Models
{
    [Table("SCANPROCESS")]
    public partial class SCANPROCESS : PARENTENTITY
    {
        //استمارة المسح والتحريات الحقلية
        public SCANPROCESS() {
            CREATION_DATE = DateTime.Now;

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        public string ORDERNUM { get; set; }
        public DateTime ORDERDATE { get; set; }


        public decimal DOCSTYPEId { get; set; }
        [ForeignKey("DOCSTYPEId")]
        public virtual DOCTYPES DOCTYPES { get; set; }

        //المستفيد
        public decimal BENEFICIALId { get; set; }
        [ForeignKey("BENEFICIALId")]
        public virtual BENEFICIAL BENEFICIAL { get; set; }

        //المحافظة
        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        //القرية
        public decimal VILLAGEId { get; set; }
        [ForeignKey("VILLAGEId")]
        public virtual VILLAGE VILLAGE { get; set; }

        //الدائرة
        public decimal CIRCLEId { get; set; }
        [ForeignKey("CIRCLEId")]
        public virtual CIRCLE CIRCLE { get; set; }

        //الوحدة الارشادية
        public decimal INDICId { get; set; }
        [ForeignKey("INDICId")]
        public virtual INDIC INDIC { get; set; }

        //الناحية
        public decimal SIDEId { get; set; }
        [ForeignKey("SIDEId")]
        public virtual SIDE SIDE { get; set; }

        //المنطقة
        public decimal ZONEId { get; set; }
        [ForeignKey("ZONEId")]
        public virtual ZONE ZONE { get; set; }

        //الفرع
        public decimal BBRANCHId { get; set; }
        [ForeignKey("BBRANCHId")]
        public virtual BBRANCH BBRANCH { get; set; }


        //مساحة التحول المرخصة
        public string LICENCETOTALAREA { get; set; }

        public string REALESTATENUM { get; set; }

        //المنطقة العقارية
        public decimal AREAId { get; set; }
        [ForeignKey("AREAId")]
        public virtual AREA AREA { get; set; }


        //المصدر المائي
        public decimal IRRSRCId { get; set; }
        [ForeignKey("IRRSRCId")]
        public virtual CONSTANT IRRIGATIONRESOURCE { get; set; }

        public string XVAL { get; set; }
        public string YVAL { get; set; }

        //الطاقة الاروائية
        public string IRRPOWER { get; set; }

        //رخصة المصدر المائي
        public string LICENCIRRSOURCE { get; set; }

        public string LICENCENUM { get; set; }
        public string LICENCEDATE { get; set; }
        //نوع الماء وصلاحيته للري
        public decimal WATTYPId { get; set; }
        [ForeignKey("WATTYPId")]
        public virtual CONSTANT WATERTYPE { get; set; }

        //طبوغرافية الحقل
        public string WATERSOURCELOCATION { get; set; }

        //نسبة الميول
        public string EARTHSLOPE { get; set; }

        public string VOLUME { get; set; }

        public string TREETYPE { get; set; }

        //المساحة المزروعة
        public string TREEAREA { get; set; }

        //اسلوب الري
        public string TREEIRRIGATIONTYPE { get; set; }

        //عمر الاشجار
        public string TREEAGE { get; set; }


        //التباعد بين الاشجار
        public string TREESPACE { get; set; }

        //عدد الاشجار ضمن السطر الواحد
        public string TREEINLINE { get; set; }


        //عدد الاسطر
        public string LINECOUNT { get; set; }


        public string PLANETTYPE { get; set; }

        //المساحة المزروعة
        public string PLANETAREA { get; set; }

        //اسلوب الري
        public string PLANETIRRIGATIONTYPE { get; set; }

        public string NOTES { get; set; }


        //مصدر طاقة
        public decimal POWSRCId { get; set; }
        [ForeignKey("POWSRCId")]
        public virtual CONSTANT POWERSOURCE { get; set; }



    }
}
