using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
