using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductCategory { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
