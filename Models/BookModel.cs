using System.ComponentModel.DataAnnotations;

namespace moment3.Models {
    public class BookModel {
        // Properties
        public int Id { get; set; }

        [Display(Name = "Titel")]
        public string? Title { get; set; }

        [Display(Name = "Beskrivning")]
        public string? Description { get; set; }

        [Display(Name = "Publiceringsår")]
        public int PublishedYear { get; set; }

        public int? AuthorModelId { get; set; }
        public AuthorModel? Author { get; set; }
    }
}