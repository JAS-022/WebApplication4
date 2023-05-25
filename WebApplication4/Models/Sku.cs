using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication4.Models
{
    public class Sku
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Code")]
        public string? Code { get; set; }

        [Display(Name = "Unit Price")]
        public int? UnitPrice { get; set; }

        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? UserID { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
    }
}
