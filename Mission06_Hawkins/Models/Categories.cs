using System.ComponentModel.DataAnnotations;

namespace Mission06_Hawkins.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
