using Buffalo_Intex.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Buffalo_Intex.Models
{
    public class EFMummyRepository : IMummyRepository
    {
        private MummyDbContext context { get; set; }

        public EFMummyRepository (MummyDbContext temp)
        {
            context = temp;
        }

        public PageInfo PageInfo { get; set; }
        public IQueryable<Color> Color => context.Color;

        public IQueryable<Textilefunction> Textilefunction => context.Textilefunction;

        public IQueryable<Burialmain> Burialmain => context.Burialmain;

        public IQueryable<Bodyanalysischart> Bodyanalysischart => context.Bodyanalysischart;

        public IQueryable<Structure> Structure => context.Structure;

    }
}
