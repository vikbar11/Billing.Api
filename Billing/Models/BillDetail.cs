namespace Billing.Models
{
    public partial class BillDetail
    {
        public int BillId { get; set; }
        public int IdOrderStatus { get; set; }
        public int IdProduct { get; set; }
        public string Description { get; set; } = null!;
        public float Quantity { get; set; }
    }
}
