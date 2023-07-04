namespace ConputerShopAPI.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Order? Order { get; set; }
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
