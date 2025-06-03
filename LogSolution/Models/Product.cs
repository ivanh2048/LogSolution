namespace LogSolution.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Sector { get; set; }
        public string Alley { get; set; }
        public string Row { get; set; }
        public string ProductCode { get; set; } // 12 digits, first not 0
    }
}
