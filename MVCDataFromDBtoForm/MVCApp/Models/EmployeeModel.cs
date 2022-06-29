using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//to enable [attributes]

namespace MVCApp.Models//FrontEnd Data Model as opose to Database Model in DataLibrary Project
{
    public class EmployeeModel
    {
        //we can bypass the order of the Range arguments by specifying the attribute ErrorMessage = 
        [Display(Name ="Employee ID")]
        [Range(100000,999999, ErrorMessage = "You need to enter a valid EmployeeID")]
        public int EmployeeId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Need to supply First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Need to supply Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Need to supply Email")]
        public string EmailAddress { get; set; }
        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "Need to match Email")]
        public string ConfirmEmail { get; set; }
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Need to provide proper password length")]
        [Required(ErrorMessage = "Need to supply Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Need to match Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}