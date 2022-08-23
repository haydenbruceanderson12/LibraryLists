using System.ComponentModel.DataAnnotations;

namespace LibraryLists.Models
{
    public class LibraryFullList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Review { get; set; }

    }
}
