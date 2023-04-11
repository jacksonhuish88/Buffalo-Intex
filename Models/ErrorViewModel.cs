using System;
using System.ComponentModel.DataAnnotations;

namespace Buffalo_Intex.Models
{
    public class ErrorViewModel
    {
        [Key]
        [Required]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
