using System.ComponentModel.DataAnnotations;

namespace moment3.Models {
    public class AuthorModel {
        // Properties
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Du måste ange författarens namn.")]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}
