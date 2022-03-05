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
        [Required, StringLength(60, MinimumLength = 3),Display(Name ="Şarkı Adı")]
        public string Title { get; set; }
        [MaxLength(50),Display(Name ="Sanatçı")]
        public string Artist { get; set; }
        [Display(Name = "Çıkış Tarihi"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [MaxLength(50),Display(Name = "Şarkı Türü")]
        public string Genre { get; set; }


    }
}