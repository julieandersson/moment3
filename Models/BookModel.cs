using System.ComponentModel.DataAnnotations;

namespace moment3.Models {
    public class BookModel {
        // Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "Du måste ange en titel på boken.")]
        [Display(Name = "Titel")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Du måste ange en beskrivning av boken.")]
        [Display(Name = "Beskrivning")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Du måste ange bokens publiceringsår.")]
        [Range(1000, 9999, ErrorMessage = "Publiceringsår måste vara ett giltigt årtal.")]
        [Display(Name = "Publiceringsår")]
        public int PublishedYear { get; set; }

        [Required(ErrorMessage = "Du måste välja en författare i listan.")]
        [Display(Name = "Författare")]
        public int? AuthorModelId { get; set; }

        [Display(Name = "Författare")]
        public AuthorModel? Author { get; set; }

        // property för att undvika null-fel
        public string AuthorName => Author?.Name ?? "Okänd författare";
    }
}