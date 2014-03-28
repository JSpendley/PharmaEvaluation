using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace PharmaEvaluation.Models
{
    [Table("ContactUsSubmissions")]
    public class ContactUsSubmissionModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ContactUsId { get; set; }
       
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Telephone Number")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }   
    }

    public class ContactUsContext : DbContext
    {
        public ContactUsContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ContactUsSubmissionModel> cuSub { get; set; }
    }




}