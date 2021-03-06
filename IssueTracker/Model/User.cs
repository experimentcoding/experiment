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
    
    public partial class User
    {
        public User()
        {
            this.ProjectMembers = new HashSet<ProjectMember>();
            this.IssueHistories = new HashSet<IssueHistory>();
        }
    
        public int UsersId { get; set; }
        public byte[] FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassword { get; set; }
        public byte[] EmailAddress { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> RoleId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public virtual ICollection<IssueHistory> IssueHistories { get; set; }
        public virtual Role Role { get; set; }
    }
}
