using System.ComponentModel.DataAnnotations;

namespace LibraryLists.Models
{
    public class Library
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int ISBN { get; set; }

    }
}
