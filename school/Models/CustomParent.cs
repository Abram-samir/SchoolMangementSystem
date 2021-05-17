using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;


namespace school.Models
{
   [MetadataType(typeof(CustomParent))]
    public partial class parent
    {
       //public parent()
       //{

       //}

    }
    public class CustomParent
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]

        //[DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        //[RegularExpression("[a-zA-z]{1,50}@[a-zA-z]{1,10}.com")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        //[DataType(DataType.Password)]
        public string pass { get; set; }
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        //[DataType(DataType.Password)]
        [Compare("pass",ErrorMessage="doesn't match with password")]
        public string confirmpass { get; set; }
        [Required(ErrorMessage = "Please Enter First Name")]
        [RegularExpression("[a-zA-z]{1,50}")]
        public string fname { get; set; }
        [Required(ErrorMessage = "Please Enter First Name")]
        [RegularExpression("[a-zA-z]{1,50}")]
        public string lname { get; set; }
        [Required(ErrorMessage = "Please Enter Date of Birth")]
        //[Range(typeof(DateTime),"01/01/1960","01/01/1995")]
        public Nullable<System.DateTime> dateofbirth { get; set; }
        [Required(ErrorMessage = "Please Enter Mobile Numebr")]
        [RegularExpression("[0-9]{11}",ErrorMessage="Mobile Phone should be 11 number")]
        [Phone]
        public string mobile { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        [RegularExpression("[0-9]{1,5}-[a-zA-Z]{1,50}-[a-zA-Z]{1,50}-[a-zA-Z]{1,50}", ErrorMessage = "Data Must Like 12-StreetName-City-Country")]
        public string address { get; set; }
       [Required(ErrorMessage = "Please Enter nationalid")]

        public string nationalid { get; set; }
        [Required(ErrorMessage = "Please Enter Gender")]
        public Nullable<int> genderlid { get; set; }
        [Required(ErrorMessage = "Please Enter Country")]
        public Nullable<int> cityid { get; set; }

        public virtual parentcity parentcity { get; set; }
        public virtual SchoolGender SchoolGender { get; set; }
    }
}