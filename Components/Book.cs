using System.ComponentModel.DataAnnotations;

namespace MediaWebApp.Components
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rating { get; set; }
        public string? ImageUrl { get; set; }
    }
}

