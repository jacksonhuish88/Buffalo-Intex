using System.Collections.Generic;
using System.Linq;

namespace Buffalo_Intex.Models.ViewModels
{
    public class BurialSummaryViewModel
    {

        public IQueryable<Color> Color { get; set; }

        public IQueryable<Textilefunction> Textilefunction { get; set; }

        public IQueryable<Burialmain> Burialmain { get; set; }

        public IQueryable<Bodyanalysischart> Bodyanalysischart { get; set; }

        public IQueryable<Structure> Structure { get; set; }


    }
}
