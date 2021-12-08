using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
