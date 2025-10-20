namespace Server.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string Category { get; set; } = string.Empty;  
        public string Price { get; set; } = string.Empty;
        public bool Stocked { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}