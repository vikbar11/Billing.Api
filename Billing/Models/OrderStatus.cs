namespace Billing.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int IdOrderStatus { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
