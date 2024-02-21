﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Hawkins.Models
{
    public class NewMovie
    {
        //all the requirements for the database so far with Mission 6

        [Key]
        [Required]
        public int MovieID { get; set; }
        public int? CategoryID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
