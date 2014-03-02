using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecordAlbumSystem.Models
{
    public class RecordAlbumContext : DbContext
    {
        public RecordAlbumContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Album> Albums { get; set; }
    }
}