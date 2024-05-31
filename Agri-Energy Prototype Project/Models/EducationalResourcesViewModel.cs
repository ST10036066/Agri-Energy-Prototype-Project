using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agri_Energy_Prototype_Project.Models
{
    public class EducationalResourcesViewModel
    {
        [Key]
        public string ResourceId { get; set; }

       /*[Required(ErrorMessage = "Please type in the correct resource. For example: Potat Inc.")]
        [Display(Name = "Resources Provider")]*/
        public string ResourceProvider { get; set; }

        /*[Required(ErrorMessage = "Please specify the training date. For example")]
        [Display(Name = "Training Date")]
        [DataType(DataType.Date)] */
        public DateTime TrainingDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        


        /*[Required(ErrorMessage = "Please enter the duration of the training. For example: Two weeks.")]
        [Display(Name = "Duration")]*/
        public string Duration { get; set; }

       /* [Required(ErrorMessage = "Please indicate the type of resources. For example: Vegetable.")]
        [Display(Name = "Resources Type")]*/
        public string ResourceType { get; set; }

      /*  [Required(ErrorMessage = "Please provide the trainer's username. For example Jim.")]
        [Display(Name = "Trainer Username")]*/
        public string Trainer { get; set; }
    }
}