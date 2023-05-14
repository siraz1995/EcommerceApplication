namespace EcommerceApplication.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MedicineId { get; set; }
        public decimal OrderPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
