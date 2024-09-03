using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HRM.A.Models
{
    public class HRM_ACTIVITY_STAT
    {

        [Display(Name = "ID")]
        public string ActivityCd { get; set; }
        public string ActivityNm { get; set; }
        public string ShortNm { get; set; }
        public string IUsr { get; set; }
        public DateTime? IDt { get; set; }
        public string UUsr { get; set; }
        public DateTime? UDt { get; set; }
    }
}
