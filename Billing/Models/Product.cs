namespace Billing.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int IdProduct { get; set; }
        public string ProductName { get; set; } = null!;
        public float Price { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
