using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace school.Models
{
    [MetadataType(typeof(CustomAttendance))]
    public partial class attendence
    {

    }
    public class CustomAttendance
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Attendance Image Required")]
        public string attendfile { get; set; }
        [Required(ErrorMessage = "Please Choose Attendance Type")]
        public Nullable<int> AttTypeId { get; set; }

        public virtual attendtype attendtype { get; set; }
    }
}