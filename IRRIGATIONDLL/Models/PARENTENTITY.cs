namespace IRRIGATIONDLL.Models
{
    using System;
    using System.ComponentModel;
    public partial class PARENTENTITY
    {
        public PARENTENTITY() {
            CREATION_DATE = DateTime.Now;
        }
        [DisplayName("تاريخ  إنشاء السجل")]
        public DateTime? CREATION_DATE { get; set; }
        [DisplayName("المستخدم الذي أنشئ السجل")]
        public decimal? CREATE_USERNB { get; set; }
        [DisplayName("تاريخ  تعديل السجل")]
        public DateTime? UPDATE_DATE { get; set; }
        [DisplayName("المستخدم الذي عدّل السجل")]
        public decimal? UPDATE_USERNB { get; set; }
    }
}
