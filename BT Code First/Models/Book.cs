using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BT_Code_First.Models
{
    public class Book
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        public string Title { get; set; }
        public string Author { get; set; }
       
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}