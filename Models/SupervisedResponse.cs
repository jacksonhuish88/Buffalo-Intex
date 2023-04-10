using System.ComponentModel.DataAnnotations;

namespace Buffalo_Intex.Models
{
    public class SupervisedResponse
    {
        [Key]
        [Required]
        public int BurialId { get; set; }

        public decimal MaxCraniumLength { get; set; }

        public decimal MaxCraniumBreadth { get; set; }

        public string SciaticNotch { get; set; }

        public string SubpubicAngle { get; set; }

        public string Femur { get; set; }

        public string FemurHeadDiameter { get; set; } 
        
        public int FemurLength { get; set; }

        public string Humerus { get; set; }

        public string HumerusHeadDiameter { get; set; }

        public int HumerusLength { get; set; }

    }
}
