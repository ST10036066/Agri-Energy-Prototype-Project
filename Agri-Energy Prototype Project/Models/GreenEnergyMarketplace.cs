using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agri_Energy_Prototype_Project.Models
{
    public class GreenEnergyMarketplace
    {
        public GreenEnergyMarketplace() { }

        [Key] // Indicates that GreenMarketId is the primary key
        public int GreenMarketId { get; set; }

        public string GreenMarketProvider { get; set; } // Name of the green market provider

        public string SolutionName { get; set; } // Name of the green energy  solution

        public string SolutionDesription { get; set; } // Description of the solution
    }
}