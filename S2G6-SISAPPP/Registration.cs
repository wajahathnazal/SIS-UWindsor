//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S2G6_SISAPPP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public string TermID { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
        public virtual StudyTerm StudyTerm { get; set; }
    }
}