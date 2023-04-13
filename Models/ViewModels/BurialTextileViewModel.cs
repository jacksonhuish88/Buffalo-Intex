using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffalo_Intex.Models.ViewModels
{
    public class BurialTextileViewModel
    {
        public int BurialId { get; set; }
        public string TextileColor { get; set; }
        public string TextileStructure { get; set; }
        public string Sex { get; set; }
        public decimal BurialDepth { get; set; }
        public decimal BurialLength { get; set; }
        public decimal AgeAtDeath { get; set; }
        public string HeadDirection { get; set; }
        public string SquareNorthSouth { get; set; }
        public string NorthSouth { get; set; }
        public string SquareEastWest { get; set; }
        public string EastWest { get; set; }
        public string Area { get; set; }
        public string BurialNumber { get; set; }
        public string TextileFunction { get; set; }
        public string HairColor { get; set; }
        public string ColorValue { get; set; }
        public string StructureValue { get; set; }

        //public PageInfo PageInfo { get; set; }
    }

}
