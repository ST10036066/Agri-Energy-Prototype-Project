using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agri_Energy_Prototype_Project.Models
{
    public class SustainableFarmingHUB
    {
        public SustainableFarmingHUB() { }


        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public DateTime ProductionDate { get; set; }

        public string ProductionDetails { get; set; }

        public string ProductUsage { get; set; }

        public string Owner { get; set; }

        public string Category { get; set; }



    }
}
