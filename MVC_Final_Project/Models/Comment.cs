//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Final_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int issue_id { get; set; }
        public string rating { get; set; }
        public string comment { get; set; }
    
        public virtual User User { get; set; }
        public virtual Issue Issue { get; set; }
    }
}
