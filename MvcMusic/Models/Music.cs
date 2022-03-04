using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusic.Models
{
    public class Music
    {
        [Key]
        public int ID { get; set; }
        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [MaxLength(50)]
        [Required]
        public string Artist { get; set; }
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [MaxLength(50)]
        [Required]
        public string Genre { get; set; }


    }
}