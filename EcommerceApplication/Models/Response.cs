namespace EcommerceApplication.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Users> ListUsers { get; set; }
        public Users User { get; set; }
        public List<Medicine> ListMedicine { get; set; }
        public Medicine Medicine{ get; set; }
        public List<Card> ListCards { get; set; }
        public Card Cards { get; set; }
        public List<Orders> ListOrder { get; set; }
        public Orders Orders { get; set; }
        public List<OrderItems> ListOrderItems { get; set; }
        public OrderItems OrderItems { get; set; }
    }
}
