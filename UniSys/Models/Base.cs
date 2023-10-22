using System.ComponentModel.DataAnnotations;

namespace UniSys.Models
{
    public abstract class Base
    {
        [Key]
        [Required]
        public int id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
