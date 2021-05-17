using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace school.Models
{
    [MetadataType(typeof(CustomActivities))]
    public partial class activities
    {

    }
    public class CustomActivities
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Activity Details")]
        public string activity { get; set; }
    }
}