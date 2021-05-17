using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace school.Models
{
    [MetadataType(typeof(CustomGrades))]
    public partial class grades
    {

    }
    public class CustomGrades
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Grade Image Required")]
        public string gradefile { get; set; }
        [Required(ErrorMessage = "Please Choose Grade Type")]
        public Nullable<int> GraTypeId { get; set; }
        public virtual gradetype gradetype { get; set; }
    }
}