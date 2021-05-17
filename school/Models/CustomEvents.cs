using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace school.Models
{   
    [MetadataType(typeof(CustomEvents))]
    public partial class EV
    {

    }
    public class CustomEvents
    {
        public int id { get; set; }
         [Required(ErrorMessage = "Please Enter Events Details")]
        public string details { get; set; }
    }
}