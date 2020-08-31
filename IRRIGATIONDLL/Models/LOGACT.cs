using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRRIGATIONDLL.Models
{
    [Table("LOGACT")]
    public partial class LOGACT
    {
        //ÌÏæá ÇáãÑÇŞÈÉ

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [DisplayName("ÊÇÑíÎ ÇáÍÑßÉ")]
        public DateTime? LDATE { get; set; }
        [DisplayName("ãÚÑİ ÇáãÓÊÎÏã")]
        public decimal? USER_NB { get; set; }
        [DisplayName("ÇÓã ÇáãÓÊÎÏã")]
        public string USER_NAME { get; set; }
        [DisplayName("ÇÓã ÇáßæäÊÑæááÑ")]
        public string CONTROLLER { get; set; }
        [DisplayName("ÇÓã ÇáÚãáíÉ")]
        public string ACTION { get; set; }
        [DisplayName("ãÊÍæáÇÊ ÇáÚãáíÉ ÇáÌÏíÏÉ")]
        public string PARAMS { get; set; }
        [DisplayName("ÇáÊØÈíŞ")]
        public string APPLICATION { get; set; }
        [DisplayName("ÌáÓÉ ÇáãÓÊÎÏã")]
        public string CLIENTIP { get; set; }
        [DisplayName("ãÊÍæáÇÊ ÇáÚãáíÉ ÇáŞÏíãÉ")]
        public string PARAMS_OLD { get; set; }
    }
}
