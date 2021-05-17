using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace school.Models
{
    [MetadataType(typeof(CustomStudent))]
    public partial class student
    {

    }
    public class CustomStudent
    {
        public int id { get; set; }
         [Required(ErrorMessage = "Please Enter Parent nationalid")]
        public string pnationalid { get; set; }
         [Required(ErrorMessage = "Please Enter Name")]
         [RegularExpression("[a-zA-z]{1,50}")]

        public string name { get; set; }
        [Required(ErrorMessage = "Please Enter Code")]
        [RegularExpression("[0-9]{1,28}")]
        public string code { get; set; }
        [Required(ErrorMessage = "Please Enter Date of Birth")]
        public Nullable<System.DateTime> dateofbirth { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please Enter Age")]
        [RegularExpression("[0-9]{1,28}")]
        [Range(5,15)]
        public string age { get; set; }
         [Required(ErrorMessage = "Please Enter Gender")]
        public string StGender { get; set; }

         public virtual SchoolGender SchoolGender { get; set; }
    }
}