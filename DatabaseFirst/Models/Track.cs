using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatabaseFirst.Models
{
    [Table("tblTracks")]
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumID  { get; set; }
    }
}