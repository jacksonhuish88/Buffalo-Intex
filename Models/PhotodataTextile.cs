using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Buffalo_Intex.Models
{
    public partial class PhotodataTextile
    {
        [Key]
        [Required]
        public long MainPhotodataid { get; set; }
        public long MainTextileid { get; set; }
    }
}
