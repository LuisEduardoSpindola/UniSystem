using System.ComponentModel.DataAnnotations.Schema;

namespace UniSys.Models
{
    public class Suplie : Base
    {
        [ForeignKey("Course")]
        public int IdCourse { get; set; }

        public Course Course { get; set; }
    }
}
