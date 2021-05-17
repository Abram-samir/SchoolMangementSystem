using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace school.Models
{
    [MetadataType(typeof(CustomSchool))]
    public partial class schools
    {

    }
    public class CustomSchool
    {
        public string id { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string email { get; set; }
         [Required(ErrorMessage = "Please Enter Password")]
        public string pass { get; set; }
        [Required(ErrorMessage = "Please Enter Confirm Password")]
         //[DataType(DataType.Password)]
        [Compare("pass", ErrorMessage = "doesn't match with password")]
        public string confirmpass { get; set; }
        [Required(ErrorMessage = "Please Enter School Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please Enter Mobile Numebr")]
        [RegularExpression("[0-9]{11}", ErrorMessage = "Mobile Phone should be 11 number")]
        [Phone]
        public string mobile { get; set; }
    }
}