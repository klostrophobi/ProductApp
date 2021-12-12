using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDetails { get; set; }
        public List<Product> Products { get; set; }
    }
}
