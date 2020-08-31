using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IRRIGATIONDLL.Models
{    
    [Table("LOGERR")]
    public partial class LOGERR
    {
        //ÃœÊ· «·√Œÿ«¡
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        [DisplayName(" «—ÌŒ «·Œÿ√")]
        public DateTime? LDATE { get; set; }
        [DisplayName("„⁄—› «·„” Œœ„")]
        public decimal? USER_NB { get; set; }
        [DisplayName("«”„ «·„” Œœ„")]
        public string USER_NAME { get; set; }
        [DisplayName("«”„ «·ﬂÊ‰ —Ê··—")]
        public string CONTROLLER { get; set; }
        [DisplayName("«”„ «·⁄„·Ì…")]
        public string ACTION { get; set; }
        [DisplayName("—”«·… «·Œÿ√")]
        public string MESSAGE { get; set; }
        [DisplayName("„”«— «·Œÿ√")]
        public string TRACE { get; set; }
        [DisplayName("«· ÿ»Ìﬁ")]
        public string APPLICATION { get; set; }
    }
}
