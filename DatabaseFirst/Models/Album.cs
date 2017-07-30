using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace DatabaseFirst.Models
{
    [Table("tblAlbums")]

    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<tblTracks> Tracks { get; set; }
    }
}