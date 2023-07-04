namespace ConputerShopAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public ProductType? ProductType { get; set; }
    }
}
