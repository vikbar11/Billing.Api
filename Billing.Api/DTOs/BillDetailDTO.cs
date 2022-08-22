namespace Billing.Api.DTOs
{
    public class BillDetailDTO
    {
        public int IdBillDetailDTO { get; set; }
        public string? DescriptionDTO { get; set; }
        public int IdBillDTO { get; set; }
        public int IdProductDTO { get; set; }
        public int QuantityDTO { get; set; }
    }
}
