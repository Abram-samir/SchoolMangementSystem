using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace school.Models
{
    [MetadataType(typeof(CustomSchedule))]
    public partial class schedule
    {

    }
    public class CustomSchedule
    {
        public int id { get; set; }
                [Required(ErrorMessage = "Schedule Image Required")]

        public string schedulefile { get; set; }
            [Required(ErrorMessage = "Please Choose Schedule Type")]
        public Nullable<int> ScheTypeId { get; set; }

        public virtual scheduletype scheduletype { get; set; }
    }
}