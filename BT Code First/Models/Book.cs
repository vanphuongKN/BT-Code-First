using System.ComponentModel.DataAnnotations;

namespace BT_Code_First.Models
{
    public class Book
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}