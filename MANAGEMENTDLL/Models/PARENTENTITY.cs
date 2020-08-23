namespace MANAGEMENTDLL.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class PARENTENTITY
    {
        public PARENTENTITY() {
            CREATION_DATE = DateTime.Now;
        }
        [DisplayName("تاريخ  إنشاء السجل")]
        public DateTime CREATION_DATE { get; set; }
        public decimal USERNB { get; set; }
    }
}
