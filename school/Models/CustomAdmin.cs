using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace school.Models
{
    [MetadataType(typeof(CustomAdmin))]

    public partial class admin
    {

    }

    public class CustomAdmin
    {
        
            public int id { get; set; }
            [Required(ErrorMessage = "Please Enter Email")]
            [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
            public string email { get; set; }
            [Required(ErrorMessage = "Please Enter Password")]
            public string pass { get; set; }
            [Required(ErrorMessage = "Please Enter Confirm Password")]
            [Compare("pass", ErrorMessage = "doesn't match with password")]
            public string confirmpass { get; set; }
        
    }
}