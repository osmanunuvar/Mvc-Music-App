using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusic.Models
{
    public class MusicDbContext:DbContext
    {
        public MusicDbContext():base("MusicDbContext")
        {

        }
        public DbSet<Music> Musics { get; set; }
    }
}