namespace IRRIGATIONDLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("BENEFICIAL")]
    public partial class BENEFICIAL : PARENTENTITY
    {
        //مستفيد
        public BENEFICIAL() {
            CREATION_DATE = DateTime.Now;
        
        }
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("رقم معرف)")]
        public decimal Id { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string FATHERNAME { get; set; }
        public string MOTHERNAME { get; set; }
        public string KAIDPLACE { get; set; }
        public string KAIDDATE { get; set; }
        public string KAIDISSUE { get; set; }
        public string CARDNUM { get; set; }
        public string NATIONALNUM { get; set; }

        public string ADDRESS { get; set; }
        public string WORKPHONE { get; set; }
        public string HOMEPHONE { get; set; }
        public string MOBILE { get; set; }


    }
}
