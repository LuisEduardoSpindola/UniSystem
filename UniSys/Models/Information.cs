using System.ComponentModel.DataAnnotations.Schema;

namespace UniSys.Models
{
    public class Information : Base
    {
        [ForeignKey("Suplie")]
        public int IdSuplie { get; set; }
        public Course Suplie { get; set; }
    }
}
