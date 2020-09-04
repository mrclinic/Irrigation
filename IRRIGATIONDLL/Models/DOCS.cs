using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRRIGATIONDLL.Models
{
    [Table("DOCS")]
    public partial class DOCS : PARENTENTITY
    {
        // الوثائق المرفقة
        public DOCS() {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف")]
        public decimal Id { get; set; }
        [DisplayName("الاسم")]
        public string NAME { get; set; }
        [DisplayName("معرف الجدول المرتبط")]
        public decimal RECORDID { get; set; }
        [DisplayName("مسار الملف")]
        public string IMAGEPATH { get; set; }
        [DisplayName("تاريخ الرفع")]
        public DateTime UPLOADDATE { get; set; }
        [DisplayName("عنوان الملف")]
        public string TITLE { get; set; }
        [DisplayName("الجدول المرتبط")]
        public string TABLENAME { get; set; }

    }
}
