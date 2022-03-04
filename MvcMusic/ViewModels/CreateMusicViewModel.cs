using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusic.ViewModels
{
    public class CreateMusicViewModel
    {
        [Required, StringLength(60, MinimumLength = 3),Display(Name ="Şarkı Adı")]
        public string Title { get; set; }
        [MaxLength(50),Required,Display(Name ="Sanatçı")]
        public string Artist { get; set; }
        [Display(Name = "Çıkış Tarihi"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [MaxLength(50),Required,Display(Name ="Şarkı Türü")]
        public string Genre { get; set; }

        public IEnumerable<SelectListItem> ListItems { get; set; } 
    }
}