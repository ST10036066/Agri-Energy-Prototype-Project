using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agri_Energy_Prototype_Project.Models
{
    public class CollaborationsViewModel
    {
        public CollaborationsViewModel() { }

        [Key]public string CollaborationId { get; set; }

        [Required(ErrorMessage = "Please enter your username. For example farmLife")]
        [Display(Name = "Username")]
        public string CollabUserName { get; set; }


        [Required(ErrorMessage = "Please enter the employee's name. For example John.")]
        [Display(Name = "Employee Name")]
        public string CollabEmployeeName { get; set; }

        [Required(ErrorMessage = "Ensure you are using letters or anything part thereof. For example I need more solar equipment.")]
        [Display(Name = "Reason For the collaboration")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "Ensure you are using letters or anything part thereof. For example Solar Panels ")]
        [Display(Name = "Interested Product")]
        public string InterestProduct{get; set; }

        [Required(ErrorMessage = "Please enter the correct manner of communication. For example Zoom.")]
        [Display(Name = "Communication Tool")]
        public string Tool {get; set;}

        [Required(ErrorMessage = "Please enter the correct date by using the date format.")]
        [Display(Name = "Date of Collaboration")]
        public string CollabDate { get; set; }
}
}