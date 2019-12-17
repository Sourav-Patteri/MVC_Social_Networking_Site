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
    using System.IO;
    using System.Xml.Serialization;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Comments = new HashSet<Comment>();
            this.Issues = new HashSet<Issue>();
        }
    
        public int Id { get; set; }
        
        [Display(Name = "First Name")] [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string first_name { get; set; }
        [Display(Name = "Last Name")] [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string last_name { get; set; }
        [Display(Name = "Phone")] [Required] [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        
        [Display(Name = "Email ID")] [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")] [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")] [DataType(DataType.Password)] [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issue> Issues { get; set; }

        public void ExportToXml(User userId)
        {
            StreamWriter writer = File.CreateText(@"C:\Users\soura\OneDrive - Georgian College\Desktop\GEORGIAN\C#\UsersList.Xml");
            XmlSerializer x = new XmlSerializer(typeof(User));
            x.Serialize(writer, userId);  
            writer.Close();
        }
        public void ImportFromXml(User userId)
        {
            StreamReader reader = File.OpenText(@"C:\Users\soura\OneDrive - Georgian College\Desktop\GEORGIAN\C#\UsersList.Xml");
            XmlSerializer x = new XmlSerializer(typeof(User));

            userId = (User)x.Deserialize(reader);
            reader.Close();
        }
    }
}
