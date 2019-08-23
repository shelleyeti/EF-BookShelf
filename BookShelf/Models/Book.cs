﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(13), MinLength(10)]
        [Display(Name = "ISBN")]
        public double ISBN { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "Author")]
        public Author Author { get; set; }

        [Required]
        [Display(Name = "Owner")]
        public ApplicationUser Owner { get; set; }
    }
}
