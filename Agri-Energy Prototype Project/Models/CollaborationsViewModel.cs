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

        [Key] // Indicates that CollaborationId is the primary key
        public string CollaborationId { get; set; }

        [Required(ErrorMessage = "Please enter your username. For example farmLife")]
        [Display(Name = "Username")] // Display label for the CollabUserName property
        public string CollabUserName { get; set; }

        [Required(ErrorMessage = "Please enter the employee's name. For example John.")]
        [Display(Name = "Employee Name")] // Display label for the CollabEmployeeName property
        public string CollabEmployeeName { get; set; }

        [Required(ErrorMessage = "Ensure you are using letters or anything part thereof. For example I need more solar equipment.")]
        [Display(Name = "Reason For the collaboration")] // Display label for the Reason property
        public string Reason { get; set; }

        [Required(ErrorMessage = "Ensure you are using letters or anything part thereof. For example Solar Panels ")]
        [Display(Name = "Interested Product")] // Display label for the InterestProduct property
        public string InterestProduct { get; set; }

        [Required(ErrorMessage = "Please enter the correct manner of communication. For example Zoom.")]
        [Display(Name = "Communication Tool")] // Display label for the Tool property
        public string Tool { get; set; }

        [Required(ErrorMessage = "Please enter the correct date by using the date format.")]
        [Display(Name = "Date of Collaboration")] // Display label for the CollabDate property
        [DataType(DataType.Date)] // Specify the data type as Date
        public DateTime CollabDate { get; set; }
    }
}