using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApp.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Username { get; set; }
        [Column(TypeName = "Varchar(16)")]
        public string Password { get; set; }
    }
}
