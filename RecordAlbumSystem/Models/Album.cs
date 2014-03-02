using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecordAlbumSystem.Models
{
    public class Album
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }
        [Display(Name = "Artist")]
        public string Artist { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "Estimated Value")]
        public decimal EstimatedValue { get; set; }

    }
}