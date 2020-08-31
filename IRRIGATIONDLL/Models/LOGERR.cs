using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IRRIGATIONDLL.Models
{    
    [Table("LOGERR")]
    public partial class LOGERR
    {
        //���� �������
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        [DisplayName("����� �����")]
        public DateTime? LDATE { get; set; }
        [DisplayName("���� ��������")]
        public decimal? USER_NB { get; set; }
        [DisplayName("��� ��������")]
        public string USER_NAME { get; set; }
        [DisplayName("��� �����������")]
        public string CONTROLLER { get; set; }
        [DisplayName("��� �������")]
        public string ACTION { get; set; }
        [DisplayName("����� �����")]
        public string MESSAGE { get; set; }
        [DisplayName("���� �����")]
        public string TRACE { get; set; }
        [DisplayName("�������")]
        public string APPLICATION { get; set; }
    }
}
