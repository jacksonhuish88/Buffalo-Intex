


using Buffalo_Intex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffalo_Intex.Models.ViewModels
{
    // CALLS TWO THINGS SO THAT THEY BOTH CAN BE RETURNED IN THE HOMECONTROLLER
    public class MummyViewModel
    {
        public IQueryable<Burialmain> Burialmain { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
