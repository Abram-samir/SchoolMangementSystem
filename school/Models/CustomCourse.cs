using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace school.Models
{
    [MetadataType(typeof(CustomCourse))]

    public partial class course
    {

    }
    public class CustomCourse
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Course Name")]
        public string coursename { get; set; }
        [Required(ErrorMessage = "Please Enter Course Code")]
        [RegularExpression("[0-9]{1,50}")]
        public string coursecode { get; set; }
        [Required(ErrorMessage = "Please  choose Semester")]
        public Nullable<int> SemesterId { get; set; }

        public virtual Schoolsemester Schoolsemester { get; set; }
    }
}