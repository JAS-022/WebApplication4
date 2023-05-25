namespace WebApplication4.Models
{
    public class PurchaseItem
    {
        public int ID { get; set; }
        public string? PurchaseOrderID { get; set; }
        public string? SkuID { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? UserID { get; set; }
    }
}
