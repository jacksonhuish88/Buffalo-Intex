using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffalo_Intex.Models.ViewModels
{
    public class PageInfo
    {
        // ESTABLISH PAGE INFO VARIABLES
        public int TotalNumMummies { get; set; }
        public int MummiesPerPage { get; set; }
        public int CurrentPage { get; set; }
        // Figure out how many pages you need
        public int TotalPages => (int)Math.Ceiling((double)TotalNumMummies / MummiesPerPage);

    }
}
