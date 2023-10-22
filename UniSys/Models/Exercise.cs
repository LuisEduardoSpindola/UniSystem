using System.ComponentModel.DataAnnotations.Schema;

namespace UniSys.Models
{
    public class Exercise : Base
    {
        [ForeignKey("Suplie")]
        public int IdSuplie { get; set; }
        public Course Suplie { get; set; }
        public DateTime DateTime { get; set; }
        public float Value { get; set; }
    }
}
