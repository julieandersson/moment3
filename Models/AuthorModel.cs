namespace moment3.Models {
    public class AuthorModel {
        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}
