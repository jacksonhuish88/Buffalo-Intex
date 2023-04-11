using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Buffalo_Intex.Models
{
    public partial class Decoration
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public int? Decorationid { get; set; }
        public string Value { get; set; }
    }
}
