using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string BookTitle { get; set; } = string.Empty;

        [Required]
        public string BookDescription { get; set; } = string.Empty;

        [Required]
        public string BookAuthor { get; set; } = string.Empty;
    }
}
