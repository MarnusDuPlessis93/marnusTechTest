using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClinicManagement.Core.ViewModel
{
    public class UserViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }
        [Required]
        [Display(Name = "Is Active")]
        public bool? IsActive { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }


    }
}