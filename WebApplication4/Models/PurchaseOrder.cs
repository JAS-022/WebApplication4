using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class PurchaseOrder
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public string? Status { get; set; }

        //[NotMapped]
        //public List<SelectListItem> Statuses { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "New", Text = "New" },
        //    new SelectListItem { Value = "Completed", Text = "Completed" },
        //    new SelectListItem { Value = "Cancelled", Text = "Cancelled"  },
        //};

        public string? AmountDue { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? UserID { get; set; }
        public bool IsActive { get; set; }
    }
}
