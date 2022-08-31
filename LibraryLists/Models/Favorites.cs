using System.ComponentModel.DataAnnotations;

namespace LibraryLists.Models
{
    public class Favorites
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Title is a required field.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The Authors Name is a required field.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "ISBN is a required field.")]
        public int ISBN { get; set; }
    }
}
