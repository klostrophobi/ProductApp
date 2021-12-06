using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
    }
}
