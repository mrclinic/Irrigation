namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    //INDICATIVEUNIT
    [Table("INDIC")]
    public partial class INDIC : BASEUNIT
    {
        //وحدة إرشادية
        public INDIC() {
            CREATION_DATE = DateTime.Now;
        }
        [DisplayName("المحافظة")]

        public decimal GOVId { get; set; }
        [ForeignKey("GOVId")]
        public virtual GOVERNORATE GOVERNORATE { get; set; }

        [DisplayName("المنطقة")]

        public decimal ZONEId { get; set; }
        [ForeignKey("ZONEId")]
        public virtual ZONE ZONE { get; set; }
        [DisplayName("الناحية")]
        public decimal SIDEId { get; set; }
        [ForeignKey("SIDEId")]
        public virtual SIDE SIDE { get; set; }
        [DisplayName("القرية")]
        public decimal VILId { get; set; }
        [ForeignKey("VILId")]
        public virtual VILLAGE VILLAGE { get; set; }
        [DisplayName("شعبة في دائرة زراعة")]
        public decimal AGRISECId { get; set; }
        [ForeignKey("AGRISECId")]
        public virtual AGRISEC AGRISEC { get; set; }
    }
}
