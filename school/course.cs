//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace school
{
    using System;
    using System.Collections.Generic;
    
    public partial class course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public course()
        {
            this.homework = new HashSet<homework>();
        }
    
        public int id { get; set; }
        public string coursename { get; set; }
        public string coursecode { get; set; }
        public Nullable<int> SemesterId { get; set; }
    
        public virtual Schoolsemester Schoolsemester { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<homework> homework { get; set; }
    }
}