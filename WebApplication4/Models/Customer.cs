using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication4.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string? LastName { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        //public string FullName
        //{
        //    get
        //    {
        //        return FirstName + " " + LastName;
        //    }
        //}

        [Display(Name = "Mobile Number")]
        [StringLength(10)]
        [Required]
        public string? MobileNumber { get; set; }

        [Display(Name = "City")]
        [Required]
        public string? City { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime TimeStamp { get; set; }

        public string? UserID { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

    }
}
