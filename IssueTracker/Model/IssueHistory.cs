//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueTracker.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class IssueHistory
    {
        public int IssueHistoryId { get; set; }
        public int IssueId { get; set; }
        public int AssignedUserId { get; set; }
        public int AssignedDate { get; set; }
        public string Comments { get; set; }
    
        public virtual Issue Issue { get; set; }
        public virtual User User { get; set; }
    }
}