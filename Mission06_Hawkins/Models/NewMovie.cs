﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Hawkins.Models
{
    public class NewMovie
    {
        //all the requirements for the database so far with Mission 6

        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
