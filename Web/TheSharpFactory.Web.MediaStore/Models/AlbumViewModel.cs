using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheSharpFactory.Web.Models
{
    public class AlbumViewModel
    {
        public int AlbumId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Artist { get; set; }
    }
}
