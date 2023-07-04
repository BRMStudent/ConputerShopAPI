namespace ConputerShopAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int TotalPrice { get; set; }
        public int? Customer { get; set; }
    }
}
