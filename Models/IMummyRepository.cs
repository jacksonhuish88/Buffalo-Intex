using System.Collections.Generic;
using System.Linq;

namespace Buffalo_Intex.Models
{
    public interface IMummyRepository
    {
        IQueryable<Color> Color { get; }

        IQueryable<Textilefunction> Textilefunction { get; }
        IQueryable<Burialmain> Burialmain { get; }

        IQueryable<Bodyanalysischart> Bodyanalysischart { get; }

        IQueryable<Structure> Structure { get; }
    }
}
