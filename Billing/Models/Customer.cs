namespace Billing.Models
{
    public class Customer
    {
        public Customer()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int IdCustomerDTO { get; set; }
        public string FirstNameDTO { get; set; } = null!;
        public string LastNameDTO { get; set; } = null!;
        public string EmailDTO { get; set; } = null!;
        public string IdCardDTO { get; set; } = null!;

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
