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
    
    public partial class student
    {
        public int id { get; set; }
        public Nullable<int> pnationalid { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public Nullable<System.DateTime> dateofbirth { get; set; }
        public string address { get; set; }
        public string age { get; set; }
        public Nullable<int> StGender { get; set; }
    
        public virtual SchoolGender SchoolGender { get; set; }
    }
}