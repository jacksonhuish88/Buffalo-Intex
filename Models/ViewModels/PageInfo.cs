using System;

namespace Buffalo_Intex.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumMummy { get; set; }

        public int MummyPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages  => (int) Math.Ceiling((double) TotalNumMummy / MummyPerPage);
    }
}
