using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hawkins.Models
{
    public class NewMovie
    {
        //all the requirements for the database so far with Mission 6

        [Key]
        [Required]
        public int MovieID { get; set; }
        [ForeignKey("CategoryID")]
        public int? CategoryID { get; set; }
        public Categories? Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be greater than 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required( ErrorMessage = "Enter yes or no for the edited field.")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
