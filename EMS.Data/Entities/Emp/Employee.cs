using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EMS.Data.Entities.Emp
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; } = string.Empty; 
        public string Lastname { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public DateTime DateofJoin { get; set; }
        public DateTime DateofBirth { get; set; }
        public string AadharNumber { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}